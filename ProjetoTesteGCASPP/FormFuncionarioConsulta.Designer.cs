
namespace ProjetoTesteGCASPP
{
    partial class FormFuncionarioConsulta
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
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnNome,
            this.ColumnDataNascimento,
            this.ColumnSalario});
            this.dgvFuncionarios.Location = new System.Drawing.Point(52, 64);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(432, 150);
            this.dgvFuncionarios.TabIndex = 0;
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
            // ColumnDataNascimento
            // 
            this.ColumnDataNascimento.HeaderText = "Data de Nascimento";
            this.ColumnDataNascimento.Name = "ColumnDataNascimento";
            // 
            // ColumnSalario
            // 
            this.ColumnSalario.HeaderText = "Salário";
            this.ColumnSalario.Name = "ColumnSalario";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(74, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(295, 20);
            this.txtId.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(35, 15);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(21, 13);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID:";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(409, 10);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // FormConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 247);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvFuncionarios);
            this.Name = "FormConsultaFuncionario";
            this.Text = "FormConsultaFuncionario";
            this.Load += new System.EventHandler(this.FormConsultaFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalario;
    }
}