using System;
using System.Windows.Forms;
using ProjetoTesteGCASPP.Entities;
using ProjetoTesteGCASPP.Repository;

namespace ProjetoTesteGCASPP
{
    public partial class AtualizaFuncionario : Form
    {
        private FuncionarioRepository funcionarioRepository = new FuncionarioRepository();
        private Funcionario funcionario = new Funcionario();
        public AtualizaFuncionario()
        {
            InitializeComponent();
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            funcionario.Nome = txtNome.Text;
            funcionario.DataNascimento = DateTime.Parse(mskDataNascimento.Text);
            funcionario.Salario = double.Parse(txtSalario.Text);

            if (MessageBox.Show("Deseja realmente atualizar este funcionário ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                funcionarioRepository.Update(funcionario);
            }
            else 
            {
                return;
            }
        }
    }
}
