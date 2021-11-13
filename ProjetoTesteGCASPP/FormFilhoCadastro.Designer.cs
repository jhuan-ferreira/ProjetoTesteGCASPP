
namespace ProjetoTesteGCASPP
{
    partial class FormFilhoCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvFilhos = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskTxtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.btnCadastra = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.DataDeNascimento = new System.Windows.Forms.Label();
            this.columnPai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboxPai = new System.Windows.Forms.ComboBox();
            this.Pai = new System.Windows.Forms.Label();
            this.cntxMenuStripFilho = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilhos)).BeginInit();
            this.cntxMenuStripFilho.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFilhos
            // 
            this.dgvFilhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilhos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnNome,
            this.columnDataNascimento,
            this.columnPai});
            this.dgvFilhos.ContextMenuStrip = this.cntxMenuStripFilho;
            this.dgvFilhos.Location = new System.Drawing.Point(39, 112);
            this.dgvFilhos.Name = "dgvFilhos";
            this.dgvFilhos.Size = new System.Drawing.Size(431, 150);
            this.dgvFilhos.TabIndex = 0;
            // 
            // columnId
            // 
            this.columnId.HeaderText = "ID";
            this.columnId.Name = "columnId";
            // 
            // columnNome
            // 
            this.columnNome.HeaderText = "Nome";
            this.columnNome.Name = "columnNome";
            // 
            // columnDataNascimento
            // 
            this.columnDataNascimento.HeaderText = "Data de Nascimento";
            this.columnDataNascimento.Name = "columnDataNascimento";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(125, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(205, 20);
            this.txtNome.TabIndex = 1;
            // 
            // mskTxtDataNascimento
            // 
            this.mskTxtDataNascimento.Location = new System.Drawing.Point(125, 73);
            this.mskTxtDataNascimento.Mask = "00/00/0000";
            this.mskTxtDataNascimento.Name = "mskTxtDataNascimento";
            this.mskTxtDataNascimento.Size = new System.Drawing.Size(67, 20);
            this.mskTxtDataNascimento.TabIndex = 2;
            this.mskTxtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.Enabled = false;
            this.btnAtualiza.Location = new System.Drawing.Point(420, 73);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(75, 23);
            this.btnAtualiza.TabIndex = 3;
            this.btnAtualiza.Text = "Atualizar";
            this.btnAtualiza.UseVisualStyleBackColor = true;
            this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // btnCadastra
            // 
            this.btnCadastra.Location = new System.Drawing.Point(420, 44);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(75, 23);
            this.btnCadastra.TabIndex = 4;
            this.btnCadastra.Text = "Cadastrar";
            this.btnCadastra.UseVisualStyleBackColor = true;
            this.btnCadastra.Click += new System.EventHandler(this.btnCadastra_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(81, 18);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(38, 13);
            this.Nome.TabIndex = 5;
            this.Nome.Text = "Nome:";
            // 
            // DataDeNascimento
            // 
            this.DataDeNascimento.AutoSize = true;
            this.DataDeNascimento.Location = new System.Drawing.Point(12, 76);
            this.DataDeNascimento.Name = "DataDeNascimento";
            this.DataDeNascimento.Size = new System.Drawing.Size(107, 13);
            this.DataDeNascimento.TabIndex = 6;
            this.DataDeNascimento.Text = "Data de Nascimento:";
            // 
            // columnPai
            // 
            this.columnPai.HeaderText = "Pai";
            this.columnPai.Name = "columnPai";
            // 
            // cboxPai
            // 
            this.cboxPai.FormattingEnabled = true;
            this.cboxPai.Location = new System.Drawing.Point(125, 44);
            this.cboxPai.Name = "cboxPai";
            this.cboxPai.Size = new System.Drawing.Size(121, 21);
            this.cboxPai.TabIndex = 7;
            // 
            // Pai
            // 
            this.Pai.AutoSize = true;
            this.Pai.Location = new System.Drawing.Point(81, 49);
            this.Pai.Name = "Pai";
            this.Pai.Size = new System.Drawing.Size(25, 13);
            this.Pai.TabIndex = 8;
            this.Pai.Text = "Pai:";
            // 
            // cntxMenuStripFilho
            // 
            this.cntxMenuStripFilho.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.cntxMenuStripFilho.Name = "cntxMenuStripFilho";
            this.cntxMenuStripFilho.Size = new System.Drawing.Size(121, 48);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.atualizarToolStripMenuItem.Text = "Atualizar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // FormFilhoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 274);
            this.Controls.Add(this.Pai);
            this.Controls.Add(this.cboxPai);
            this.Controls.Add(this.DataDeNascimento);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.btnCadastra);
            this.Controls.Add(this.btnAtualiza);
            this.Controls.Add(this.mskTxtDataNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvFilhos);
            this.Name = "FormFilhoCadastro";
            this.Text = "FormFilhoCadastro";
            this.Load += new System.EventHandler(this.FormFilhoCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilhos)).EndInit();
            this.cntxMenuStripFilho.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilhos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDataNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskTxtDataNascimento;
        private System.Windows.Forms.Button btnAtualiza;
        private System.Windows.Forms.Button btnCadastra;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label DataDeNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPai;
        private System.Windows.Forms.ComboBox cboxPai;
        private System.Windows.Forms.Label Pai;
        private System.Windows.Forms.ContextMenuStrip cntxMenuStripFilho;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
    }
}