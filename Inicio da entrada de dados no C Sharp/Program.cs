using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio_da_entrada_de_dados_no_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("------------------------------------");
            Console.WriteLine("         Analisador de idade");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Digite o ano atual:");
            int anoatual = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano em que você nasceu :");
            int nascimento = Int32.Parse(Console.ReadLine());
            int id= anoatual - nascimento;
            Console.WriteLine("Sua idade é!");
            Console.WriteLine(id);
            if (id < 10)
            {
                Console.WriteLine("Você é uma criança, não pode dirigir!");
            }
            else if (id > 10 && id < 18)
            {
                Console.WriteLine("Você é um adolescente, não pode dirigir!");
            }
            else if (id >= 18 && id <= 25)
            {
                Console.WriteLine("Você já é maior de idade, pode ditigir!");
            }
            else if (id > 25 && id < 60)
            {
                Console.WriteLine("Você já é um adulto e pode dirigir!");
            }
            else if (id >= 60)   
            {
                Console.WriteLine("Você já é idoso, precisa descansar!");
            }
    
            Console.ReadLine();
        }
    }
}
