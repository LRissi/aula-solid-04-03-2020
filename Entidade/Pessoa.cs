using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_solid_04_03_2020.Entidade
{
    internal class Pessoa
    {
        public string Nome { get; set;}
        public string Documento {get; set; }
        public string Email {get; set; }

        public Pessoa(string nome, string documento, string email)
        {
            Nome = nome ?? throw new Exception("Nome é obrigatório!");
            Documento = documento ?? throw new Exception("Documento é obrigatório!");
            Email = email ?? throw new Exception("Email é obrigatório!");

        }

        public override string ToString()
        {
            return $"Nome: {Nome}\n" +
                $"Documento: {Documento}\n" +
                $"Email: {Email}";
        }
    }
}
