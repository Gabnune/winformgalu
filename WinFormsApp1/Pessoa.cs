using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Pessoa
    {
        public Pessoa() { }
        public Pessoa(int id, string nome, string cpf, string email, string senha, string endereco)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.senha = senha;
            this.endereco = endereco;
        }

        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string endereco { get; set; }
    }
}
