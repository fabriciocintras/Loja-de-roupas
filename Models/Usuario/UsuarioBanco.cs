using System.Collections.Generic;

using MySqlConnector;
namespace etapa_3.Models
{
    public class UsuarioBanco
    {
        private const string dadosConexao = "Database=CadastroEtapa4; Data Source= localhost;User Id= root";

        public void Insert(Usuario novoUsuario)
        {
            MySqlConnection Conexao = new MySqlConnection(dadosConexao);

            Conexao.Open();

            string query = "INSERT INTO UsuarioEtapa4(nome,login, senha) VALUES (@Nome, @Login, @Senha)";

            MySqlCommand comando = new MySqlCommand(query,Conexao);

            comando.Parameters.AddWithValue("@Nome", novoUsuario.Nome);
            comando.Parameters.AddWithValue("@Login", novoUsuario.Login);
            comando.Parameters.AddWithValue("@Senha", novoUsuario.Senha);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public List<Usuario> Query()
        {
            MySqlConnection Conexao = new MySqlConnection(dadosConexao);
            Conexao.Open();
            string query = "SELECT * FROM UsuarioEtapa4";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            MySqlDataReader reader = comando.ExecuteReader();

            List<Usuario> lista = new List<Usuario>();
            while (reader.Read())
            {
                Usuario user = new Usuario();
                user.Id = reader.GetInt32("id");

                if(!reader.IsDBNull(reader.GetOrdinal("Nome")))
                {
                    user.Nome = reader.GetString("Nome");
                }
                if(!reader.IsDBNull(reader.GetOrdinal("Login")))
                {
                    user.Login = reader.GetString("Login");
                }
                if(!reader.IsDBNull(reader.GetOrdinal("Senha")))
                {
                    user.Senha = reader.GetString("Senha");
                }
                lista.Add(user);
                
            }
            Conexao.Close();
            return lista;
        }

        public Usuario QueryLogin(Usuario usuario)
        {
            MySqlConnection Conexao = new MySqlConnection(dadosConexao);
            Conexao.Open();
            string sql = " SELECT * FROM UsuarioEtapa4 WHERE login = @Login AND senha = @Senha";

            MySqlCommand comandoQuery = new MySqlCommand(sql, Conexao);
            comandoQuery.Parameters.AddWithValue("@Login",usuario.Login );
            comandoQuery.Parameters.AddWithValue("@Senha",usuario.Senha );
            MySqlDataReader reader = comandoQuery.ExecuteReader();
            Usuario novoUsuario = null;
            if(reader.Read())
            {
                novoUsuario = new Usuario();
                novoUsuario.Id = reader.GetInt32("Id");

                if(!reader.IsDBNull(reader.GetOrdinal("Nome")))
                    novoUsuario.Nome = reader.GetString("Nome");

                if(!reader.IsDBNull(reader.GetOrdinal("Login")))
                    novoUsuario.Login = reader.GetString("Login");

                if(!reader.IsDBNull(reader.GetOrdinal("Senha")))
                    novoUsuario.Senha= reader.GetString("Senha");

            }
            Conexao.Close();
            return novoUsuario;

        }

    }
}