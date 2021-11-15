using System;
using System.Windows.Forms;
using ProjetoTesteGCASPP.Entities;
using ProjetoTesteGCASPP.Repository;

namespace ProjetoTesteGCASPP
{
    public partial class FormExcluiFuncionario : Form
    {
        private FuncionarioRepository funcionarioRepository = new FuncionarioRepository();
        private Funcionario funcionario = new Funcionario();
        public FormExcluiFuncionario()
        {
            InitializeComponent();
        }

        private void FormExcluiFuncionario_Load(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = funcionarioRepository.FindAll();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            funcionario.Nome = dgvFuncionarios.CurrentRow.Cells[1].Value.ToString();
            funcionario.DataNascimento = DateTime.Parse(dgvFuncionarios.CurrentRow.Cells[2].Value.ToString());
            funcionario.Salario = double.Parse(dgvFuncionarios.CurrentRow.Cells[3].Value.ToString());

            dgvFuncionarios.DataSource = funcionarioRepository.Delete(funcionario);
        }
    }
}
