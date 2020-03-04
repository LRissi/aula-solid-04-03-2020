using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_solid_04_03_2020.Entidade
{
    internal class Conta
    {
        public Pessoa Pessoa {get; set;}
        public decimal Saldo {get; set;}

        public void Depositar(decimal valor)
        {
            Console.WriteLine($"{Pessoa.Nome} depositou R${valor}.");
            Console.WriteLine($"Saldo atual: R${Saldo}.");
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            Console.WriteLine($"{Pessoa.Nome} sacou R${valor}.");
            Console.WriteLine($"Saldo atual: R${Saldo}.");
            Saldo -= valor;
        }
    }
}
