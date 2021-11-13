using System;
using System.Windows.Forms;
using ProjetoTesteGCASPP.Repository;

namespace ProjetoTesteGCASPP
{
    public partial class FormFuncionarioConsulta : Form
    {
        private FuncionarioRepository funcionarioRepository = new FuncionarioRepository();
        public FormFuncionarioConsulta()
        {
            InitializeComponent();
        }

        private void FormConsultaFuncionario_Load(object sender, EventArgs e)
        {
            PopulaGrid();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.Rows.Clear();
            
            var funcionario = funcionarioRepository.Get(int.Parse(txtId.Text));

            if (!(funcionario is null))
            {
                dgvFuncionarios.Rows[0].Cells[0].Value = funcionario.IdFuncionario;
                dgvFuncionarios.Rows[0].Cells[1].Value = funcionario.Nome;
                dgvFuncionarios.Rows[0].Cells[2].Value = funcionario.DataNascimento;
                dgvFuncionarios.Rows[0].Cells[3].Value = funcionario.Salario;
            }
            else 
            {
                MessageBox.Show("Não foi encontrado nenhum funcionário com este ID", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PopulaGrid();
            } 
            
        }

        public void PopulaGrid()
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

            txtId.Text = "";
        }

    }
}
