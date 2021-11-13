using ProjetoTesteGCASPP.Repository;
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
    public partial class FormFilhoConsulta : Form
    {
        private FilhoRepository filhoRepository = new FilhoRepository();
        FuncionarioRepository funcionarioRepository = new FuncionarioRepository();
        public FormFilhoConsulta()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            dgvFilhos.Rows.Clear();

            var filho = filhoRepository.Get(int.Parse(txtId.Text));

            if (!(filho is null))
            {
                dgvFilhos.Rows[0].Cells[0].Value = filho.FilhoId;
                dgvFilhos.Rows[0].Cells[1].Value = filho.Nome;
                dgvFilhos.Rows[0].Cells[2].Value = filho.DataNascimento;
                dgvFilhos.Rows[0].Cells[3].Value = funcionarioRepository.Get(filho.FuncionarioId).Nome;
            }
            else
            {
                MessageBox.Show("Não foi encontrado nenhum funcionário com este ID", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                PopulaGrid();
            }
        }

        private void FormFilhoConsulta_Load(object sender, EventArgs e)
        {
            PopulaGrid();

        }


        private void PopulaGrid()
        {
            dgvFilhos.Rows.Clear();

            FilhoRepository _filhoRepository = new FilhoRepository();
            FuncionarioRepository _funcionarioRepository = new FuncionarioRepository();

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

            txtId.Text = "";
        }


    }
}
