using System;
using System.Linq;
using System.Windows.Forms;
using ProjetoTesteGCASPP.Entities;
using ProjetoTesteGCASPP.Repository;

namespace ProjetoTesteGCASPP
{
    public partial class FormFilhoCadastro : Form
    {
        private FuncionarioRepository funcionarioRepository = new FuncionarioRepository();
        private FilhoRepository filhoRepository = new FilhoRepository();
        private Filho filho = new Filho();
        public FormFilhoCadastro()
        {
            InitializeComponent();
        }

        private void FormFilhoCadastro_Load(object sender, EventArgs e)
        {
            FuncionarioRepository funcionarioRepository = new FuncionarioRepository();
            cboxPai.DataSource = funcionarioRepository.FindAll().Select(p => p.Nome).ToList();
            PopulaGrid();
            cboxPai.Text = "";
        }


        private void PopulaGrid()
        {
            dgvFilhos.Rows.Clear();

            FilhoRepository _filhoRepository = new FilhoRepository();
            FuncionarioRepository funcionarioRepository = new FuncionarioRepository();

            int i = 0;

            foreach (var filho in _filhoRepository.FindAll())
            {
                dgvFilhos.Rows.Add();

                dgvFilhos.Rows[i].Cells["columnId"].Value = filho.FilhoId;
                dgvFilhos.Rows[i].Cells["columnNome"].Value = filho.Nome;
                dgvFilhos.Rows[i].Cells["columnDataNascimento"].Value = filho.DataNascimento;
                dgvFilhos.Rows[i].Cells["columnPai"].Value = funcionarioRepository.Get(filho.FuncionarioId).Nome;

                i++;
            }

        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {

            filho.Nome = txtNome.Text;
            filho.DataNascimento = DateTime.Parse(mskTxtDataNascimento.Text);
            filho.FuncionarioId = funcionarioRepository.GetIdByName(Convert.ToString(cboxPai.SelectedValue));

            filhoRepository.Insert(filho);

            PopulaGrid();

        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            txtNome.Text = dgvFilhos.CurrentRow.Cells[1].Value.ToString();
            mskTxtDataNascimento.Text = dgvFilhos.CurrentRow.Cells[2].Value.ToString();
            cboxPai.Text = dgvFilhos.CurrentRow.Cells[3].Value.ToString();

            filho.FilhoId = int.Parse(dgvFilhos.CurrentRow.Cells[0].Value.ToString());
            filho.Nome = txtNome.Text;
            filho.DataNascimento = DateTime.Parse(mskTxtDataNascimento.Text);
            filho.FuncionarioId = funcionarioRepository.FindAll().Where(p => p.Nome == dgvFilhos.CurrentRow.Cells[3].Value.ToString()).Select(p => p.IdFuncionario).FirstOrDefault();

            btnCadastra.Enabled = false;
            btnAtualiza.Enabled = true;
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {

            filho.FilhoId = int.Parse(dgvFilhos.CurrentRow.Cells[0].Value.ToString());
            filho.Nome = txtNome.Text;
            filho.DataNascimento = DateTime.Parse(mskTxtDataNascimento.Text);
            filho.FuncionarioId = funcionarioRepository.FindAll().Where(p => p.Nome == dgvFilhos.CurrentRow.Cells[3].Value.ToString()).Select(p => p.IdFuncionario).FirstOrDefault();

            filhoRepository.Update(filho);
            PopulaGrid();
            LimpaFormulario();

        }


        public void LimpaFormulario()
        {
            txtNome.Text = "";
            mskTxtDataNascimento.Text = "";
            cboxPai.Text = "";
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filho.FilhoId = int.Parse(dgvFilhos.CurrentRow.Cells[0].Value.ToString());
            filho.Nome = dgvFilhos.CurrentRow.Cells[1].Value.ToString();
            filho.DataNascimento = DateTime.Parse(dgvFilhos.CurrentRow.Cells[2].Value.ToString());
            filho.FuncionarioId = funcionarioRepository.FindAll().Where(p => p.Nome == dgvFilhos.CurrentRow.Cells[3].Value.ToString()).Select(p => p.IdFuncionario).FirstOrDefault();

            if ((MessageBox.Show("Você deseja realmente deletar este funcionário ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes))
            {
                filhoRepository.Delete(filho);
            }
            else
            {
                return;
            }

            PopulaGrid();
        }
    }
}
