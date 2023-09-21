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
            Menu();     
       
        }

        static void Menu()
        {
            string menuopcoes = "";

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
        }

        //CRIAR UMA FUNÇÃO PARA CADA OPERAÇÃO. EM QUE NO FINAL ELA VAI CHAMAR A FUNÇÃO DO MENU NOVAMENTE
        //// Desafios
        // 1- Crie uma nova opção na calculadora (opção número 5 do menu) que retorne o resto da divisão.
        // 2- Crie uma nova opção na calculadora (opção número 6 do menu) que retorne o resultado da potenciação de uma determinada base pelo seu expoente. Exemplo **2³ = 8**.
    }
}
