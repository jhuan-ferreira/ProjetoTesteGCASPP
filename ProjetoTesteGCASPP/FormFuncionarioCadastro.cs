using ProjetoTesteGCASPP.Entities;
using System;
using System.Windows.Forms;
using ProjetoTesteGCASPP.Repository;

namespace ProjetoTesteGCASPP
{
    public partial class FormFuncionarioCadastro : Form
    {
        Funcionario funcionario = new Funcionario();
        private FuncionarioRepository funcionarioRepository = new FuncionarioRepository();
        public FormFuncionarioCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            funcionario.Nome = txtNome.Text;
            funcionario.DataNascimento = DateTime.Parse(mskTtxtDataNascimento.Text);
            funcionario.Salario = double.Parse(txtSalario.Text);

            if (!(funcionarioRepository.ValidaCamposFuncionarios(funcionario.Salario) == true))
            {
                funcionarioRepository.Insert(funcionario);
            }
            else
            {
                MessageBox.Show("Não é permitido incluir funcionários com salário 0", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            PopulaGrid();
            LimpaFormulario();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            PopulaGrid();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcionario.Nome = dgvFuncionarios.CurrentRow.Cells[1].Value.ToString();
            funcionario.DataNascimento = DateTime.Parse(dgvFuncionarios.CurrentRow.Cells[2].Value.ToString());
            funcionario.Salario = double.Parse(dgvFuncionarios.CurrentRow.Cells[3].Value.ToString());

            txtNome.Text = funcionario.Nome;
            mskTtxtDataNascimento.Text = Convert.ToString(funcionario.DataNascimento);
            txtSalario.Text = Convert.ToString(funcionario.Salario);

            btnCadastro.Enabled = false;
            btnAtualiza.Enabled = true;
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            funcionario.IdFuncionario = int.Parse(dgvFuncionarios.CurrentRow.Cells[0].Value.ToString());
            funcionario.Nome = txtNome.Text;
            funcionario.DataNascimento = DateTime.Parse(mskTtxtDataNascimento.Text);
            funcionario.Salario = double.Parse(txtSalario.Text);

            if (!(funcionarioRepository.ValidaCamposFuncionarios(funcionario.Salario) == true) && (MessageBox.Show("Você deseja realmente atualizar o cadastro deste funcionário ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes))
            {
                funcionarioRepository.Update(funcionario);
            }
            PopulaGrid();

            LimpaFormulario();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcionario.IdFuncionario = int.Parse(dgvFuncionarios.CurrentRow.Cells[0].Value.ToString());
            funcionario.Nome = dgvFuncionarios.CurrentRow.Cells[1].Value.ToString();
            funcionario.DataNascimento = DateTime.Parse(dgvFuncionarios.CurrentRow.Cells[2].Value.ToString());
            funcionario.Salario = double.Parse(dgvFuncionarios.CurrentRow.Cells[3].Value.ToString());

            btnCadastro.Enabled = false;
            btnAtualiza.Enabled = false;

            if (MessageBox.Show("Você deseja realmente deletar este funcionário ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                funcionarioRepository.Delete(funcionario);

                PopulaGrid();
                
            }
            else
            {
                return;            
            }

        }

        private void PopulaGrid()
        {
            dgvFuncionarios.Rows.Clear();
            FuncionarioRepository _funcionarioRepository = new FuncionarioRepository();

            int i = 0;

            foreach (var funcionario in _funcionarioRepository.FindAll())
            {
                dgvFuncionarios.Rows.Add();
                dgvFuncionarios.Rows[i].Cells["columnId"].Value = funcionario.IdFuncionario;
                dgvFuncionarios.Rows[i].Cells["columnNome"].Value = funcionario.Nome;
                dgvFuncionarios.Rows[i].Cells["columnDataNascimento"].Value = funcionario.DataNascimento;
                dgvFuncionarios.Rows[i].Cells["columnSalario"].Value = funcionario.Salario;
                
                i++;
            }

        }

        public void LimpaFormulario()
        {
            txtNome.Text = "";
            txtSalario.Text = "";
            mskTtxtDataNascimento.Text = "";
            btnCadastro.Enabled = true;
            btnAtualiza.Enabled = false;
        }

    }
}
