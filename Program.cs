using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_de_Lógica_em_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menuopcoes = "";
            float numero1 = 0.0f;
            float numero2 = 0.0f;
            float resultsoma = 0.0f;
            float resultsub = 0.0f;
            float resultmulti = 0.0f;


            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("CALCULADORA - INCIANTES EM CSharp");
            Console.WriteLine("SELECIONE UMA DAS OPÇÕES A SEGUIR PARA CONTINUAR :");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("[1] - Somar");
            Console.WriteLine("[2] - Subtrair");
            Console.WriteLine("[3] - Multiplicador");
            Console.WriteLine("[4] - Dividir");
            Console.WriteLine("[0] - Sair");
            menuopcoes = Console.ReadLine();
            Console.Clear();

            switch (menuopcoes)
            {
                    case "1":
                    Console.WriteLine("INFOMRE O 1º NÚMERO :");
                    numero1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("INFORME O 2º NÚMERO :");
                    numero2  = float.Parse(Console.ReadLine());
                    resultsoma = numero1 + numero2;
                    Console.WriteLine("O RESULTADO DA SOMA DESSE DOIS NÚMEROS É : " + resultsoma);
                    //A partir daqui, o usuário deve ser re-direcionado para o menu principal
                    break;
                    case "2":
                    Console.WriteLine("INFORME O 1º NÚMERO :");
                    numero1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("INFORME O 2º NÚMERO :");
                    numero2 = float.Parse(Console.ReadLine());
                    resultsub = numero1 - numero2;
                    Console.WriteLine("O RESULTADO DA SUBTRAÇÃO DESSES DOIS NÚMEROS É : " + resultsub);
                    //A partir daqui, o usuário deve ser re-direcionado para o menu principal
                        break;
                    case "3":
                    Console.WriteLine("INFORME O 1º NÚMERO :");
                    numero1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("INFORME O 2º NÚMERO :");
                    numero2 = float.Parse(Console.ReadLine());
                    resultmulti = numero1 * numero2;
                    Console.WriteLine("O RESULTADO DA MULTIPLICAÇÃO DESSES DOIS NÚMEROS É : " + resultmulti);
                    //A partir daqui, o usuário deve ser re-direcionado para o menu principal
                    break;
                    case "4":
                        break;
                    case "5":
                        break;

            }






            Console.ReadLine();
        }
    }
}
