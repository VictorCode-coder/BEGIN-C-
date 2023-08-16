using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            ano();


            Console.ReadLine();
      
        }
        static void ano()
        {
            Console.WriteLine("Digite o ano atual:");
            int anoatual = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano em que você nasceu :");
            int nascimento = int.Parse(Console.ReadLine());
            idade(anoatual, nascimento);
            
        }

        static void idade(int cal_id1, int cal_id2)
        {
            int ID = cal_id1 - cal_id2;
            Console.WriteLine("Sua idade é:");
            Console.WriteLine(ID);
            fasevida(ID);
        }
        static void fasevida(int fasevida)
        {
            if (fasevida == 0)
            {
                Console.WriteLine("VOCÊ AINDA NÃO NASCEU!");
            }
            else if (fasevida > 0 && fasevida < 10)
            {
                Console.Write("Você é uma criança");
            }
            else if (fasevida > 10 && fasevida < 20)
            {
                Console.WriteLine("Você é um adolescente");
            }
            else if (fasevida >= 20)
            {
                Console.WriteLine("Você é um adulto");
            }
        }

    }   
}
