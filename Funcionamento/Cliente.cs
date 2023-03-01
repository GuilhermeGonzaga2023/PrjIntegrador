using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Banco;

namespace RegradeNegocio
{
    public class Cliente
    {
        public static string Apelido { get; set; }
        public static string Senha { get; set; }
        public static string Nome { get; set; }
        public static string Placa { get; set; }
        public Cliente() 
        {
        }

        public static string Cadastro(string apelido, string senha, string nome, string placa )
        {
            string result = ClienteBD.Cadastro(apelido, senha,nome,placa);
            if (result == "OK")
            {
                return result;
            }
            else
            {
                return result;
            }
        }
        public static string Atualizar(string nome, string placa)
        {
            string result = ClienteBD.Atualizar(nome, placa);
            if (result == "OK")
            {
                return result = "Atualizado com Sucesso !";
            }
            else
            {
                return result;
            }
        }
        public static DataSet buscar(string nome, string status)
        {
            DataSet ds = ClienteBD.Buscar(nome,status);
            return ds;
        }
        public static string AtualizarSenha(string apelido, string senha)
        {
            string result = ClienteBD.AtualizarSenha(apelido, senha);
            if (result == "OK")
            {
                return result;
            }
            else
            {
                return result;
            }
        }
        public static string[] Acessar(string apelido, string senha)
        {
            string[] dados = ClienteBD.Acessar(apelido, senha);
            if (dados[0] == "OK")
            {
                dados[0] = "Seja Bem vindo";
                return dados;
            }
            else
            {
                return dados;
            }
            
        }
    }
        
}   
