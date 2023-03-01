using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class FuncionarioBD
    {
        public FuncionarioBD() { }
        public static string Cadastro(string senha)
        {
            try
            {
                SqlConnection conexao = new SqlConnection();
                SqlCommand command = new SqlCommand();
                command.CommandText = "";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;
                MD5 criaCripto = MD5.Create();
                byte[] vetorByte = Encoding.ASCII.GetBytes(senha); //pegando a senha e transformandi em vetor de byte
                byte[] vetorHash = criaCripto.ComputeHash(vetorByte); //computeHash é quem vai criptografar o vetorByte
                StringBuilder senhaCriptografado = new StringBuilder(); //
                for (int i = 0; i < vetorHash.Length; i = i + 1)
                {
                    senhaCriptografado.Append(vetorHash[i].ToString("X2")); //para usar o append tem que usar o StringBuilder
                    //cada vez que passar por aqui, vai aumentando
                }
                command.Parameters.Clear();
                command.Parameters.AddWithValue("", senhaCriptografado);
                conexao.Open();
                command.ExecuteNonQuery();
                conexao.Close();
                return "C";
            }
            catch (SqlException ex)
            {
                return "Erro: " + ex.HResult + " " + ex.Message;
            }
            catch (NullReferenceException es)
            {
                return "Problemas com a string de conexão do banco de dados!!! erro: " + es.Message;
            }
        }
        public static string Atualizar(string nome)
        {
            try
            {
                SqlConnection conexao = new SqlConnection();
                SqlCommand command = new SqlCommand();
                command.CommandText = "pu_Cliente";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("", nome);
                conexao.Open();
                command.ExecuteNonQuery();
                conexao.Close();
                return "A";
            }
            catch (SqlException ex)
            {
                return "Erro: " + ex.HResult + " " + ex.Message;
            }
            catch (NullReferenceException es)
            {
                return "Problemas com a string de conexão do banco de dados!!! erro: " + es.Message;
            }
        }
        public static DataSet Buscar(string nome, string status)
        {
            SqlConnection conexao = new SqlConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "ps_Cliente";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = conexao;
            command.Parameters.AddWithValue("nome", nome);
            command.Parameters.AddWithValue("statusCliente", status);
            SqlDataAdapter adaptacao = new SqlDataAdapter(command);
            DataSet mostrarDados = new DataSet();
            adaptacao.Fill(mostrarDados);
            return mostrarDados;
        }
        public static string AtualizarSenha(string apelido, string novaSenha)
        {
            try
            {
                SqlConnection conexao = new SqlConnection();
                SqlCommand command = new SqlCommand();
                command.CommandText = "pu_SenhaCliente";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;
                MD5 criaCripto = MD5.Create();
                byte[] vetorByte = Encoding.ASCII.GetBytes(novaSenha); //pegando a senha e transformandi em vetor de byte
                byte[] vetorHash = criaCripto.ComputeHash(vetorByte); //computeHash é quem vai criptografar o vetorByte
                StringBuilder senhaCriptografado = new StringBuilder(); //
                for (int i = 0; i < vetorHash.Length; i = i + 1)
                {
                    senhaCriptografado.Append(vetorHash[i].ToString("X2")); //para usar o append tem que usar o StringBuilder
                    //cada vez que passar por aqui, vai aumentando
                }
                command.Parameters.Clear();
                command.Parameters.AddWithValue("apelido", apelido.ToLower());
                command.Parameters.AddWithValue("senha", senhaCriptografado.ToString());
                conexao.Open();
                command.ExecuteNonQuery();
                conexao.Close();
                return "fun";
            }
            catch (SqlException ex)
            {
                return "Erro: " + ex.HResult + " " + ex.Message;
            }
            catch (NullReferenceException es)
            {
                return "Problemas com a string de conexão do banco de dados!!! erro: " + es.Message;
            }
        }
        public static string[] Acessar(string apelido, string senha)
        {
            string[] dadosUser = new string[4];
            try
            {
                SqlConnection conexao = new SqlConnection();
                SqlCommand acoesSQL = new SqlCommand();
                SqlDataReader leitor;
                acoesSQL.CommandText = "loginCliente";
                acoesSQL.CommandType = CommandType.StoredProcedure;
                acoesSQL.Connection = conexao;
                MD5 criaCripto = MD5.Create();
                byte[] vetorByte = Encoding.ASCII.GetBytes(senha); //pegando a senha e transformandi em vetor de byte
                byte[] vetorHash = criaCripto.ComputeHash(vetorByte); //computeHash é quem vai criptografar o vetorByte
                StringBuilder senhaCriptografado = new StringBuilder(); //
                for (int i = 0; i < vetorHash.Length; i = i + 1)
                {
                    senhaCriptografado.Append(vetorHash[i].ToString("X2"));
                }
                acoesSQL.Parameters.AddWithValue("apelido", apelido.ToLower());
                acoesSQL.Parameters.AddWithValue("senha", senhaCriptografado.ToString());
                conexao.Open();
                leitor = acoesSQL.ExecuteReader();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    dadosUser[1] = leitor.GetInt32(0).ToString();
                    dadosUser[2] = leitor.GetString(1);
                    dadosUser[3] = leitor.GetString(10);
                    conexao.Close();
                    leitor.Close();
                    dadosUser[0] = "achou";
                    return dadosUser;
                }
                else
                {
                    conexao.Close();
                    leitor.Close();
                    dadosUser[0] = "Usuario ou senha não encontrado";
                    return dadosUser;
                }
            }
            catch (SqlException ex)
            {
                dadosUser[0] = "Erro" + ex.Message + ex.HResult;
                return dadosUser;

            }
        }
    }
}
