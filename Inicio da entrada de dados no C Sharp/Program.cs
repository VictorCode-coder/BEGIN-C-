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
            
            
            Console.WriteLine("Digite o 1º Número:");
            int N1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º Número:");
            int N2 = Int32.Parse(Console.ReadLine());
            if ((N1 * N2) > (N1 + N2))
            {
                Console.WriteLine("A multiplicação é maior que a soma!");
            }
            else if ((N1 * N2) == (N1 + N2))
            {
                Console.WriteLine("A multiplicação e a soma são iguai!");

            }
            else
            {
                Console.WriteLine("A soma é maior que a multilplicação!");

            }



            Console.ReadLine();
        }
    }
}
