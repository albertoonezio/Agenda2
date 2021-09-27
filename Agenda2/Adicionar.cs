using Agenda2.connection;
using System;
using System.Windows.Forms;

namespace Agenda2
{
    public partial class frmAdicionar : Form
    {
        private Connection con;
        private int total = 0;

        public frmAdicionar(int totalUsers)
        {
            InitializeComponent();

            total = totalUsers + 1;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.TextLength < 0)
                {
                    MessageBox.Show("O campo de nome não pode está vázio!", "Cadastrar Nova Agenda!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtFone.TextLength < 0)
                {
                    MessageBox.Show("O campo de telefone não pode ficar vázio!", "Cadastrar Nova Agenda!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string nome = txtNome.Text;
                string fone = txtFone.Text;

                con = new Connection();

                con.Insert(total, nome, fone);

                MessageBox.Show("Cadastro realizado com sucesso!", "Cadastrar Nova Agenda!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Cadastro não realizado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
