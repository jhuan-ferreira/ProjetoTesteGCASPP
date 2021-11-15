using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTesteGCASPP
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formCadadastro = new FormFuncionarioCadastro();
            formCadadastro.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formConsultaFuncionario = new FormFuncionarioConsulta();
            formConsultaFuncionario.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formFilhoCadastro = new FormFilhoCadastro();
            formFilhoCadastro.Show();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formFilhoConsulta = new FormFilhoConsulta();
            formFilhoConsulta.Show();
        }
    }
}
