using ProjetoTesteGCASPP.Entities;
using System;
using System.Windows.Forms;
using ProjetoTesteGCASPP.Repository;

namespace ProjetoTesteGCASPP
{
    public partial class FormCadastro : Form
    {
        Funcionario funcionario = new Funcionario();
        private FuncionarioRepository funcionarioRepository = new FuncionarioRepository();
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
            dgvFuncionarios.DataSource = funcionarioRepository.FindAll();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = funcionarioRepository.FindAll();
        }
    }
}
