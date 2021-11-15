using System;
using System.Windows.Forms;
using ProjetoTesteGCASPP.Repository;

namespace ProjetoTesteGCASPP
{
    public partial class FormConsultaFuncionario : Form
    {
        private FuncionarioRepository funcionarioRepository = new FuncionarioRepository();
        public FormConsultaFuncionario()
        {
            InitializeComponent();
        }

        private void FormConsultaFuncionario_Load(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = funcionarioRepository.FindAll();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource =  funcionarioRepository.Get(int.Parse(txtId.Text));
        }
    }
}
