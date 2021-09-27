namespace Agenda2
{
    partial class frmCadastro
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgwAgenda = new System.Windows.Forms.DataGridView();
            this.lblTitleAgenda = new System.Windows.Forms.Label();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(11, 288);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(107, 36);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgwAgenda
            // 
            this.dgwAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Fone});
            this.dgwAgenda.Location = new System.Drawing.Point(11, 75);
            this.dgwAgenda.Name = "dgwAgenda";
            this.dgwAgenda.Size = new System.Drawing.Size(369, 207);
            this.dgwAgenda.TabIndex = 6;
            // 
            // lblTitleAgenda
            // 
            this.lblTitleAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAgenda.Location = new System.Drawing.Point(12, 9);
            this.lblTitleAgenda.Name = "lblTitleAgenda";
            this.lblTitleAgenda.Size = new System.Drawing.Size(368, 63);
            this.lblTitleAgenda.TabIndex = 7;
            this.lblTitleAgenda.Text = "Agenda";
            this.lblTitleAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCadastro.Location = new System.Drawing.Point(273, 288);
            this.btnNovoCadastro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(107, 36);
            this.btnNovoCadastro.TabIndex = 8;
            this.btnNovoCadastro.Text = "Novo";
            this.btnNovoCadastro.UseVisualStyleBackColor = true;
            this.btnNovoCadastro.Click += new System.EventHandler(this.btnNovoCadastro_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Fone
            // 
            this.Fone.HeaderText = "Fone";
            this.Fone.Name = "Fone";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(143, 288);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 36);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 333);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNovoCadastro);
            this.Controls.Add(this.lblTitleAgenda);
            this.Controls.Add(this.dgwAgenda);
            this.Controls.Add(this.btnConsultar);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Agenda";
            this.Activated += new System.EventHandler(this.frmCadastro_Activated);
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgwAgenda;
        private System.Windows.Forms.Label lblTitleAgenda;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fone;
        private System.Windows.Forms.Button btnDelete;
    }
}

