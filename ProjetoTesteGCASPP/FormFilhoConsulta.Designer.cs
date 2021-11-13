
namespace ProjetoTesteGCASPP
{
    partial class FormFilhoConsulta
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
            this.dgvFilhos = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilhos)).BeginInit();
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
            this.dgvFilhos.Location = new System.Drawing.Point(23, 94);
            this.dgvFilhos.Name = "dgvFilhos";
            this.dgvFilhos.Size = new System.Drawing.Size(432, 150);
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
            // columnPai
            // 
            this.columnPai.HeaderText = "Pai";
            this.columnPai.Name = "columnPai";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(38, 34);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(21, 13);
            this.Id.TabIndex = 1;
            this.Id.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(81, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(208, 20);
            this.txtId.TabIndex = 2;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(335, 30);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // FormFilhoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 256);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.dgvFilhos);
            this.Name = "FormFilhoConsulta";
            this.Text = "FormFilhoConsulta";
            this.Load += new System.EventHandler(this.FormFilhoConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilhos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilhos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPai;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnConsulta;
    }
}