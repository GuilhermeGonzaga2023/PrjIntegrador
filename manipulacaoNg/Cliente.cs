using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manipulacaoNg
{
    public class Cliente
    {
        public Cliente() { }
        public static string IdUser {get;set;} 
        public static string NomeUser { get; set; }
        public static string Cep { get; set; }
        public static string NomedaRua { get; set; }
        public static string NumerodaRua { get; set; }
        public static string ComplementoRua { get; set; }
        public static string BairrodaRua { get; set; }
        public static string CidadeRua {get;set;}
        public static string EstadodaRua { get; set; }
        public static string Apelido {get; set;}
        public static string Senha {get; set;}
        public Cliente(string apelido, string senha) 
        {
            Cliente.Apelido = apelido;
            Cliente.Senha = senha;
        }
    }
    public static string[] Acessar()
    {
        string apelido, senha;
        apelido = Cliente.Apelido;
        senha = Cliente.Senha;
        string[] result = acessoBdCliente(apelido, senha);
        if (result[0] == "ok")
        {
            return result;
        }
        else
        {
            result = acessoBdFunc(apelido, senha);
            if (result[0] == "ok")
            {
                return result;
            }
            else
            {
                return result;
            }
        }
    }
}
