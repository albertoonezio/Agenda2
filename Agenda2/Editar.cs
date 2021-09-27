using Agenda2.connection;
using Agenda2.Entities;
using System;
using System.Windows.Forms;

namespace Agenda2
{
    public partial class frmEditar : Form
    {
        private Cadastro newUser = new Cadastro();
        private Connection con;

        public frmEditar(Cadastro user)
        {
            InitializeComponent();

            newUser = user;

            txtNome.Text = newUser.Nome;
            txtFone.Text = newUser.Phone;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string fone = txtFone.Text;

            con = new Connection();

            con.Update(newUser.Id, nome, fone);

            this.Close();
        }
    }
}
