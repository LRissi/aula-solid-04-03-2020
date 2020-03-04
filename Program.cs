using aula_solid_04_03_2020.Entidade;
using aula_solid_04_03_2020.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_solid_04_03_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de pessoa");
            Console.WriteLine("Informe o nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o documento");
            string documento = Console.ReadLine();
            Console.WriteLine("Informe o email");
            string email = Console.ReadLine();

            try
            {
                Pessoa pessoa = new Pessoa(nome, documento, email);
                Console.WriteLine("Pessoa cadastrada com sucesso!");
                Console.WriteLine("Dados da pessoa:");
                Console.WriteLine(pessoa.ToString());
                Console.WriteLine("\n");
                EmailService.EnviarEmail(pessoa);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } finally
            {
                Console.ReadLine();
            }
        }
    }
}
