
namespace Agenda2
{
    partial class frmAdicionar
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
            this.txtFone = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblFone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblTitleAdicionar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFone
            // 
            this.txtFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFone.Location = new System.Drawing.Point(85, 108);
            this.txtFone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(199, 30);
            this.txtFone.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(85, 72);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(199, 30);
            this.txtNome.TabIndex = 6;
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFone.Location = new System.Drawing.Point(13, 106);
            this.lblFone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(57, 25);
            this.lblFone.TabIndex = 5;
            this.lblFone.Text = "Fone";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(11, 75);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(64, 25);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(177, 175);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(107, 36);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblTitleAdicionar
            // 
            this.lblTitleAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAdicionar.Location = new System.Drawing.Point(18, 9);
            this.lblTitleAdicionar.Name = "lblTitleAdicionar";
            this.lblTitleAdicionar.Size = new System.Drawing.Size(266, 47);
            this.lblTitleAdicionar.TabIndex = 9;
            this.lblTitleAdicionar.Text = "Adicionar";
            this.lblTitleAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 223);
            this.Controls.Add(this.lblTitleAdicionar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblFone);
            this.Controls.Add(this.lblNome);
            this.Name = "frmAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblTitleAdicionar;
    }
}