
namespace ProjetoTesteGCASPP
{
    partial class FormCadastro
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskTtxtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Salário = new System.Windows.Forms.Label();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.gpbxCadastro = new System.Windows.Forms.GroupBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.gpbxCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(119, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(205, 20);
            this.txtNome.TabIndex = 0;
            // 
            // mskTtxtDataNascimento
            // 
            this.mskTtxtDataNascimento.Location = new System.Drawing.Point(119, 52);
            this.mskTtxtDataNascimento.Name = "mskTtxtDataNascimento";
            this.mskTtxtDataNascimento.Size = new System.Drawing.Size(105, 20);
            this.mskTtxtDataNascimento.TabIndex = 1;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(119, 81);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(105, 20);
            this.txtSalario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data de Nascimento:";
            // 
            // Salário
            // 
            this.Salário.AutoSize = true;
            this.Salário.Location = new System.Drawing.Point(6, 84);
            this.Salário.Name = "Salário";
            this.Salário.Size = new System.Drawing.Size(42, 13);
            this.Salário.TabIndex = 5;
            this.Salário.Text = "Salario:";
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(98, 140);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(437, 171);
            this.dgvFuncionarios.TabIndex = 6;
            // 
            // gpbxCadastro
            // 
            this.gpbxCadastro.Controls.Add(this.btnCadastro);
            this.gpbxCadastro.Controls.Add(this.mskTtxtDataNascimento);
            this.gpbxCadastro.Controls.Add(this.txtSalario);
            this.gpbxCadastro.Controls.Add(this.Salário);
            this.gpbxCadastro.Controls.Add(this.txtNome);
            this.gpbxCadastro.Controls.Add(this.label2);
            this.gpbxCadastro.Controls.Add(this.label1);
            this.gpbxCadastro.Location = new System.Drawing.Point(12, 12);
            this.gpbxCadastro.Name = "gpbxCadastro";
            this.gpbxCadastro.Size = new System.Drawing.Size(647, 122);
            this.gpbxCadastro.TabIndex = 7;
            this.gpbxCadastro.TabStop = false;
            this.gpbxCadastro.Text = "Cadastro de Funcionário";
            this.gpbxCadastro.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(566, 93);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastro.TabIndex = 6;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 323);
            this.Controls.Add(this.gpbxCadastro);
            this.Controls.Add(this.dgvFuncionarios);
            this.Name = "FormCadastro";
            this.Text = "FormCadastro";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.gpbxCadastro.ResumeLayout(false);
            this.gpbxCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskTtxtDataNascimento;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Salário;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.GroupBox gpbxCadastro;
        private System.Windows.Forms.Button btnCadastro;
    }
}