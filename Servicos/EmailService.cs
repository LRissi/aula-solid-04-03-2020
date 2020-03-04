using aula_solid_04_03_2020.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_solid_04_03_2020.Servicos
{
    internal class EmailService
    {
        public static void EnviarEmail(Pessoa pessoa)
        {
            Console.WriteLine($"Para: {pessoa.Email}, Mensagem: Olá {pessoa.Nome}");
        }
    }
}
