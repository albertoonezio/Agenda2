using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Agenda2.connection;
using Agenda2.Entities;

namespace Agenda2
{
    public partial class frmCadastro : Form
    {
        private Connection con;
        private IList<Cadastro> users = new List<Cadastro>();
        private int total = 0;

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            con = new Connection();

            int line = dgwAgenda.CurrentRow.Index;

            Cadastro user = con.Select(users[line].Nome);

            frmEditar editar = new frmEditar(user);
            editar.Show();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            //CarregarDados();
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            frmAdicionar adicionar = new frmAdicionar(total);
            adicionar.Show();
        }

        private void frmCadastro_Activated(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            con = new Connection();

            users.Clear();

            dgwAgenda.Rows.Clear();

            users = con.SelectAll();

            total = users.Count;

            for (int i = 0; i < total; i++)
            {
                dgwAgenda.Rows.Add(new Object[]{
                    i + 1,
                    users[i].Nome,
                    users[i].Phone
                });
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con = new Connection();

            int line = dgwAgenda.CurrentRow.Index;

            int userDelete = line + 1;

            con.Delete(userDelete);

            CarregarDados();
        }
    }
}
