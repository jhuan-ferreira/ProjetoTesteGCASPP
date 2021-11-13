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
            Form formCadadastro = new FormCadastro();
            formCadadastro.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formExcluiFuncionario = new FormExcluiFuncionario();
            formExcluiFuncionario.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formConsultaFuncionario = new FormConsultaFuncionario();
            formConsultaFuncionario.Show();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAtualizaFuncionario = new AtualizaFuncionario();
            formAtualizaFuncionario.Show();
        }
    }
}
