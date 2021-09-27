
namespace Agenda2
{
    partial class frmEditar
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
            this.lblTitleEditar = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblFone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleEditar
            // 
            this.lblTitleEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleEditar.Location = new System.Drawing.Point(12, 9);
            this.lblTitleEditar.Name = "lblTitleEditar";
            this.lblTitleEditar.Size = new System.Drawing.Size(266, 47);
            this.lblTitleEditar.TabIndex = 15;
            this.lblTitleEditar.Text = "Editar Cadastro";
            this.lblTitleEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(171, 175);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(107, 36);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtFone
            // 
            this.txtFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFone.Location = new System.Drawing.Point(79, 108);
            this.txtFone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(199, 30);
            this.txtFone.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(79, 72);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(199, 30);
            this.txtNome.TabIndex = 12;
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFone.Location = new System.Drawing.Point(7, 106);
            this.lblFone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(57, 25);
            this.lblFone.TabIndex = 11;
            this.lblFone.Text = "Fone";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(5, 75);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(64, 25);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome";
            // 
            // frmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 228);
            this.Controls.Add(this.lblTitleEditar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblFone);
            this.Controls.Add(this.lblNome);
            this.Name = "frmEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.Label lblNome;
    }
}