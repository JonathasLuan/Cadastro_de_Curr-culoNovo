using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sobrenome, endereço, e_mail;
            string telefone, data_de_nascimento;
            string pretensão_salarial;

            Console.WriteLine("digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("digite seu sobrenome:");
            sobrenome = Console.ReadLine();
            Console.WriteLine("digite seu endereço:");
            endereço = Console.ReadLine();
            Console.WriteLine("digite seu e-mail:");
            e_mail = Console.ReadLine();
            Console.WriteLine("digite seu telefone:");
            telefone = Console.ReadLine();
            Console.WriteLine("digite sua data de nascimento:");
            data_de_nascimento = Console.ReadLine();
            Console.WriteLine("digite sua pretensão salarial:");
            pretensão_salarial = Console.ReadLine();
        }
    }
}
