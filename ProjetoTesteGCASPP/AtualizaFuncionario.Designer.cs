
namespace ProjetoTesteGCASPP
{
    partial class AtualizaFuncionario
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.DataDeNascimento = new System.Windows.Forms.Label();
            this.Salario = new System.Windows.Forms.Label();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(138, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(195, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(138, 99);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Location = new System.Drawing.Point(138, 62);
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.mskDataNascimento.TabIndex = 2;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(12, 28);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(38, 13);
            this.Nome.TabIndex = 3;
            this.Nome.Text = "Nome:";
            // 
            // DataDeNascimento
            // 
            this.DataDeNascimento.AutoSize = true;
            this.DataDeNascimento.Location = new System.Drawing.Point(12, 65);
            this.DataDeNascimento.Name = "DataDeNascimento";
            this.DataDeNascimento.Size = new System.Drawing.Size(107, 13);
            this.DataDeNascimento.TabIndex = 4;
            this.DataDeNascimento.Text = "Data de Nascimento:";
            // 
            // Salario
            // 
            this.Salario.AutoSize = true;
            this.Salario.Location = new System.Drawing.Point(12, 102);
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(42, 13);
            this.Salario.TabIndex = 5;
            this.Salario.Text = "Salário:";
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.Location = new System.Drawing.Point(360, 136);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(75, 23);
            this.btnAtualiza.TabIndex = 6;
            this.btnAtualiza.Text = "Atualizar";
            this.btnAtualiza.UseVisualStyleBackColor = true;
            this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // AtualizaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 177);
            this.Controls.Add(this.btnAtualiza);
            this.Controls.Add(this.Salario);
            this.Controls.Add(this.DataDeNascimento);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.mskDataNascimento);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Name = "AtualizaFuncionario";
            this.Text = "AtualizaFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label DataDeNascimento;
        private System.Windows.Forms.Label Salario;
        private System.Windows.Forms.Button btnAtualiza;
    }
}