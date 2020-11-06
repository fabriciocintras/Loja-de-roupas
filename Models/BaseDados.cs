using System;
using System.Collections.Generic;
using MySqlConnector;

namespace etapa_3.Models
{
    public class BaseDados
    {
        /*formulario*/
       /* private static List<Cliente> cliente = new List<Cliente>();

        public static void Incluir(Cliente novoCliente)
        {
            cliente.Add(novoCliente);
        }
        public static List<Cliente> Listar()
        {
            return cliente;
        }*/

        private const string dadosConexao = "Database = cadastroEtapa4; Data Source = localhost; User Id = root ";

        public void InserirForm(Cliente novoCliente)
        {
            MySqlConnection Conexao = new MySqlConnection(dadosConexao);

            Conexao.Open();

            string query = "INSERT INTO FaleConosco (Nome, Email, Mensagem) VALUES (@Nome, @Email,@Mensagem) ";

            MySqlCommand comando = new MySqlCommand(query,Conexao);

            comando.Parameters.AddWithValue("@Nome",novoCliente.Nome);
            comando.Parameters.AddWithValue("@Email",novoCliente.Email);
            comando.Parameters.AddWithValue("@Mensagem",novoCliente.Mensagem);
            comando.ExecuteNonQuery();

            Conexao.Close();

        }

        public List<Cliente> Buscar()
        {
            MySqlConnection Conexao = new MySqlConnection(dadosConexao);
            Conexao.Open();
            string query = "SELECT * FROM FaleConosco";
            MySqlCommand comando = new MySqlCommand(query,Conexao);

             MySqlDataReader reader = comando.ExecuteReader();

             List<Cliente> listaCliente = new List<Cliente>();
             while(reader.Read())
             {
                 Cliente user = new Cliente();
                 user.Id = reader.GetInt32("Id");

                if(!reader.IsDBNull(reader.GetOrdinal("Nome")))
                {
                    user.Nome = reader.GetString("Nome");
                }
                if(!reader.IsDBNull(reader.GetOrdinal("Email")))
                {
                    user.Email = reader.GetString("Email");
                }
                if(!reader.IsDBNull(reader.GetOrdinal("Mensagem")))
                {
                    user.Mensagem = reader.GetString("Mensagem");
                }
                listaCliente.Add(user);

             }

             Conexao.Close();
             return listaCliente;

        }

        
            
    }
}