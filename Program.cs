using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
            Console.WriteLine("[5] - Resto da Divisão");
            Console.WriteLine("[6] - Potência");
            Console.WriteLine("[0] - Sair");
            menuopcoes = Console.ReadLine();
            Console.Clear();

            switch (menuopcoes)
            {
                case "1":
                    Soma();
                    break;

                case "2":
                    Subtraçao();
                    break;

                case "3":
                    Multiplicacao();
                    break;

                case "4":
                    Divisao();
                    break;

                case "5":
                    Resto();
                    break;

                case "6":
                    Potencia();
                    break;

                default:
                    Console.WriteLine("FECHANDO O PROGRAMA...ADEUS (; ;)");
                    Console.ReadLine();
                    break;


            }

        }

        static void Soma()
        {
            Console.WriteLine("DIGITE O 1º NÚMERO :");
            float numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE 0 2º NÚMERO :");
            float numero2 = int.Parse(Console.ReadLine());
            float result = numero1 + numero2;
            Console.WriteLine(numero1 + " + " + numero2 + " = " + result);
            Console.ReadLine();
            Console.Clear();
            Menu();
        }
        static void Subtraçao()
        {
            Console.WriteLine("DIGITE O 1º NÚMERO :");
            float numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE 0 2º NÚMERO :");
            float numero2 = int.Parse(Console.ReadLine());
            float result = numero1 - numero2;
            Console.WriteLine(numero1 + " - " + numero2 + " = " + result);
            Console.ReadLine();
            Console.Clear();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("DIGITE O 1º NÚMERO :");
            float numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE 0 2º NÚMERO :");
            float numero2 = int.Parse(Console.ReadLine());
            float result = numero1 * numero2;
            Console.WriteLine(numero1 + " x " + numero2 + " = " + result);
            Console.ReadLine();
            Console.Clear();
            Menu();
        }

        static void Divisao()
        {
            Console.WriteLine("DIGITE O 1º NÚMERO :");
            float numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE 0 2º NÚMERO :");
            float numero2 = int.Parse(Console.ReadLine());
            if (numero2 == 0)
            {
                Console.WriteLine("NÃO É POSSÍVEL DIVIDIR POR ZERO");
                Console.ReadLine();
                Console.Clear();
                Divisao();
            }
            else
            { 
                float result = numero1 / numero2;
                Console.WriteLine(numero1 + " / " + numero2 + " = " + result);
                Console.ReadLine();
                Console.Clear();
                Menu();
            }
        }

        static void Resto()
        {
            Console.WriteLine("DIGITE O 1º NÚMERO :");
            float numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE 0 2º NÚMERO :");
            float numero2 = int.Parse(Console.ReadLine());
            if (numero2 == 0)
            {
                Console.WriteLine("NÃO É POSSÍVEL DIVIDIR POR ZERO");
                Console.ReadLine();
                Console.Clear();
                Divisao();
            }
            else
            {
                float result = numero1 % numero2;
                Console.WriteLine("O RESTO DE " + numero1 + " / " + numero2 + " é : " + result);
                Console.ReadLine();
                Console.Clear();
                Menu();
            }
        }

        static void Potencia()
        {
            double basep, expo;
            Console.WriteLine("DIGITE A BASE :");
            basep = double.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE 0 EXPOENTE :");
            expo = double.Parse(Console.ReadLine());
            Console.WriteLine($"{basep} elevado a {expo} = {Math.Pow(basep, expo)}" );
            Console.ReadLine();
            Console.Clear();
            Menu();
        }



        //CRIAR UMA FUNÇÃO PARA CADA OPERAÇÃO. EM QUE NO FINAL ELA VAI CHAMAR A FUNÇÃO DO MENU NOVAMENTE
        //// Desafios
        // 1- Crie uma nova opção na calculadora (opção número 5 do menu) que retorne o resto da divisão.(CONCLUÍDO)
        // 2- Crie uma nova opção na calculadora (opção número 6 do menu) que retorne o resultado da potenciação de uma determinada base pelo seu expoente. Exemplo **2³ = 8**.(CONCLUÍDO)
    }



















}
    
