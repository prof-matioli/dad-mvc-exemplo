using Microsoft.Data.SqlClient;
using System.Configuration;

namespace AppMVC.Model
{
    public class ProdutoRepository
    {
        private readonly string _connectionString;

        public ProdutoRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MinhaConexaoDB"].ConnectionString;
        }

        public List<Produto> ObterTodos()
        {
            var produtos = new List<Produto>();
            string sql = "SELECT Id, Nome, Preco, Quantidade FROM Produtos";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var produto = new Produto(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetDecimal(2),
                                reader.GetInt32(3)
                            );
                            produtos.Add(produto);
                        }
                    }
                }
            }
            return produtos;
        }

        public void Adicionar(Produto produto)
        {
            // SQL modificado para não incluir a coluna Id
            string sql = "INSERT INTO Produtos (Nome, Preco, Quantidade) VALUES (@Nome, @Preco, @Quantidade)";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(sql, connection))
                {
                    // O parâmetro @Id foi removido
                    command.Parameters.AddWithValue("@Nome", produto.Nome);
                    command.Parameters.AddWithValue("@Preco", produto.Preco);
                    command.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Remover(int id)
        {
            string sql = "DELETE FROM Produtos WHERE Id = @Id";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
