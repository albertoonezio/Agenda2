using Agenda2.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Agenda2.connection
{
    public class Connection
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        Cadastro user;

        public Connection()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source = DESKTOP-JKDC314\SQLEXPRESS; Initial Catalog = Agenda; Integrated Security=true; Trusted_Connection=True";

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            cmd = new SqlCommand();
        }

        public void Insert(int id, string nome, string fone)
        {
            cmd.CommandText = "insert into Agenda (Id, Nome, Phone) values (@id, @nome, @telefone)";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", fone);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            Dispolse();
        }

        public Cadastro Select(string nome)
        {
            user = new Cadastro();

            cmd.CommandText = "SELECT * FROM Agenda WHERE Nome like @varNome";
            cmd.Parameters.Add(new SqlParameter("@varNome", nome));
            cmd.Connection = con;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                user.Id = ((int)dr["Id"]);
                user.Nome = ((string)dr["Nome"]);
                user.Phone = ((string)dr["Phone"]);
            }

            Dispolse();

            return user;
        }

        public IList<Cadastro> SelectAll()
        {
            IList<Cadastro> users = new List<Cadastro>();

            cmd.CommandText = "SELECT * FROM Agenda";
            cmd.Connection = con;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                user = new Cadastro();
                user.Id = ((int)dr["Id"]);
                user.Nome = ((string)dr["Nome"]);
                user.Phone = ((string)dr["Phone"]);

                users.Add(user);
            }

            Dispolse();

            return users;
        }

        public void Update(int id, string nome, string fone)
        {
            cmd.CommandText = "update Agenda SET Nome = @nome, Phone = @telefone WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", fone);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            Dispolse();
        }

        public void Delete(int id)
        {
            cmd.CommandText = "delete Agenda WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            Dispolse();
        }

        private void Dispolse()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}