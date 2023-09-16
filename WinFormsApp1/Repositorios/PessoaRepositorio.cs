using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Repositorios
{
    public class PessoaRepositorio
    {
        private string strcon = "Server=DESKTOP-TDEFNQP\\SQLEXPRESS;Database=CrudCliente;Trusted_Connection=True;";
        public void Inserir(Pessoa pessoa)
        {
            
            string sql = "INSERT INTO Cliente (NOME, EMAIL, CPF, ENDERECO, SENHA) VALUES (@nome, @email, @cpf, @endereco, @senha)";
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(sql);

            cmd.Parameters.Add(new SqlParameter("@nome", pessoa.nome));
            cmd.Parameters.Add(new SqlParameter("@email", pessoa.email));
            cmd.Parameters.Add(new SqlParameter("@cpf", pessoa.cpf));
            cmd.Parameters.Add(new SqlParameter("@endereco", pessoa.endereco));
            cmd.Parameters.Add(new SqlParameter("@senha", pessoa.senha));

            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void Atualizar(Pessoa pessoa)
        {

            string sql = "UPDATE Cliente SET NOME = @nome, EMAIL = @email, CPF =  @cpf, ENDERECO = @endereco, SENHA = @senha WHERE ID = @id ";
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(sql);

            cmd.Parameters.Add(new SqlParameter("@nome", pessoa.nome));
            cmd.Parameters.Add(new SqlParameter("@email", pessoa.email));
            cmd.Parameters.Add(new SqlParameter("@cpf", pessoa.cpf));
            cmd.Parameters.Add(new SqlParameter("@endereco", pessoa.endereco));
            cmd.Parameters.Add(new SqlParameter("@senha", pessoa.senha));
            cmd.Parameters.Add(new SqlParameter("@id", pessoa.id));

            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void Deletar(int id)
        {

            string sql = "DELETE FROM Cliente WHERE ID = @id";
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(sql);

            cmd.Parameters.Add(new SqlParameter("@id", id));

            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public Pessoa BuscarPessoaId(int id)
        {
            string sql = "SELECT * FROM Cliente WHERE ID = @id";
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(sql);

            cmd.Parameters.Add(new SqlParameter("@id", id));

            SqlDataReader reader = cmd.ExecuteReader();

            Pessoa objPessoa = new Pessoa();
            while(reader.Read())
            {
                objPessoa.id = Convert.ToInt32(reader["ID"]);
                objPessoa.nome = Convert.ToString(reader["NOME"]);
                objPessoa.cpf = Convert.ToString(reader["CPF"]);
                objPessoa.senha = Convert.ToString(reader["SENHA"]);
                objPessoa.endereco = Convert.ToString(reader["ENDERECO"]);
                objPessoa.email = Convert.ToString(reader["EMAIL"]);
            }

            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return objPessoa;
        }

        public IEnumerable<Pessoa> BuscarTodos()
        {
            string sql = "SELECT * FROM Cliente";

            List< Pessoa > objPessoas = new List<Pessoa>();
            using (SqlConnection con = new SqlConnection(strcon))
            {
                using (SqlCommand cmd = new SqlCommand(sql))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            objPessoas.Add(new Pessoa(
                            Convert.ToInt32(reader["ID"]),
                            Convert.ToString(reader["NOME"]),
                            Convert.ToString(reader["CPF"]),
                            Convert.ToString(reader["SENHA"]),
                            Convert.ToString(reader["ENDERECO"]),
                            Convert.ToString(reader["EMAIL"])
                                ));
                        
                        }
                    }
                    con.Close();
                }
            }
            
            return objPessoas;
        }
    }
}
