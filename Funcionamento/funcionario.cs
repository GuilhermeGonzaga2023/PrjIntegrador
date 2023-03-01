using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionamento
{
    public class funcionario
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }

        public funcionario(string login, string senha, string nome) 
        {            
            Login = login;
            Senha = senha;
            Nome = nome;
        }

    }
}
