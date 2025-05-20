using Npgsql;
using System;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoWatt
{
    internal static class Program
    {

        
        public static bool dashBoarCarregado;
        public static string cpf;
        public static Morador morador;
        public static string loginText;


        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            
            Application.Run(new TelaLogin());
            dashBoarCarregado = false;

            morador = new Morador
            {
                Nome = "test",
                CPF = "123.456.789-00",
                Idade = 00,
                Endereco = "teste"
            };

        }

        public static async Task<bool> VerificaLogin(string login, string senha)
        {
            loginText = login;
            using (var conectaBanco = BancoDados.ConexaoBanco())
            {
                try
                {
                    // ✅ Abre a conexão apenas se ainda não estiver aberta
                    if (conectaBanco.State != ConnectionState.Open)
                       await conectaBanco.OpenAsync();

                    // 1. Verifica se login e senha são válidos
                    string queryLogin = "SELECT COUNT(*) FROM login WHERE loginname = @loginname AND senha = @senha";
                    using (var cmdLogin = new NpgsqlCommand(queryLogin, conectaBanco))
                    {
                        cmdLogin.Parameters.AddWithValue("@loginname", login);
                        //string senhaHash = HashSenha(senha);
                        cmdLogin.Parameters.AddWithValue("@senha", senha);

                        var result = await cmdLogin.ExecuteScalarAsync();
                        int count = Convert.ToInt32(result);

                        if (count == 0)
                            return false;
                    }

                    // 2. Busca o CPF do usuário
                    string queryCpf = "SELECT cpf FROM login WHERE loginname = @loginname";
                    string cpf = null;

                    using (var cmdCpf = new NpgsqlCommand(queryCpf, conectaBanco))
                    {
                        cmdCpf.Parameters.AddWithValue("@loginname", login);
                        var result = await cmdCpf.ExecuteScalarAsync();
                        cpf = result?.ToString();
                        Console.WriteLine("CPF retornado: " + (cpf ?? "null"));
                    }

                    // 3. Busca dados do morador
                    string queryMorador = "SELECT nome, idade, endereço FROM morador WHERE cpf = @cpf";
                    using (var cmdMorador = new NpgsqlCommand(queryMorador, conectaBanco))
                    {
                        cmdMorador.Parameters.AddWithValue("@cpf", cpf);

                        using (var reader = await cmdMorador.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                morador = new Morador
                                {
                                    CPF = cpf,
                                    Nome = reader["nome"].ToString(),
                                    Idade = Convert.ToInt32(reader["idade"]),
                                    Endereco = reader["endereço"].ToString()
                                };
                            }
                        }
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                    return false;
                }
                finally
                {
                    conectaBanco.Close();
                    Console.WriteLine("Sessão fechada");
                }
            }
        }



        public static string HashSenha(string senha)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(senha));
                return BitConverter.ToString(bytes).Replace("-", "").ToLowerInvariant();
            }
        }



        public class BancoDados
        {
            public static NpgsqlConnection ConexaoBanco()
            {

                try
                {
                    string connString = ConfigurationManager.ConnectionStrings["ConexaoBanco"].ConnectionString;
                    var conexao = new NpgsqlConnection(connString);

                    conexao.Open();

                    Console.WriteLine("Conectado Com sucesso no SupaBase");
                    return conexao;
                    Npgsql.NpgsqlConnection.ClearPool(conexao);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao Conectar : {ex.Message}");
                    return null;
                }

            }



        }
    }
}
