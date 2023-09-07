using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Inicio_da_entrada_de_dados_no_C_Sharp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Váriável que será usada no Switch do Menu
			string menu = "";
			//Variável para guardar o nome dos alunos
			string[] nome = { "", "", "", "" };
			//Variáveis para guardar a nota das duas provas.
			float[] P1 = new float[4];
			float[] P2 = new float[4];
			//Variáveis para consulta do statuos do aluno
			string nomeconsulta = "";
			string resultado2 = "";


			//Tela inicial do sistema
			Console.WriteLine("-------------------------------------------------");
			Console.WriteLine("SEJA BEM VINDO AO SISTEMA ESCOLAR DE NOTAS - 2023");
			Console.WriteLine("-------------------------------------------------");
			Console.WriteLine("ESCOLHE UMA OPÇÃO DO MENU PARA CONTINUAR....");
			Console.WriteLine("[1] LANÇAR AS NOTAS DOS ALUNOS");
			Console.WriteLine("[2] CONSULTAR PONTUAÇÃO E STATUS DO ALUNO");
			Console.WriteLine("[3] FECHAR PROGRAMA DE NOTAS");
			menu = Console.ReadLine();

			Console.Clear();

			//Switch para o Menu
			switch (menu)
			{
				case ("1"):
					for (int i = 0; i <= 3; i++)
					{
						Console.Write("DIGITE O NOME E O SOBRENOME DO ALUNO(A): ");
						nome[i] = Console.ReadLine();
						Console.WriteLine("DIGITE A SEGUIR A NOTA OBTIDA PELO ALUNO(A) NAS DUAS PROVAS");
						Console.WriteLine("PROVA 1");
						P1[i] = float.Parse(Console.ReadLine());
						Console.WriteLine("PROVA 2");
						P2[i] = float.Parse(Console.ReadLine());
						Console.Clear();
					}
					Console.Clear();
					break;

				case ("2"):
					Console.WriteLine("DIGITE O NOME DO ALUNO(A) PARA CONSULTAR O SEU STATUS: ");
					nomeconsulta = Console.ReadLine();
					if (nomeconsulta == nome[0])
					{
						Console.WriteLine("NOTA DO ALUNO(A) NA PROVA 1: " + P1[0]);
						Console.WriteLine("NOTA DO ALUNO(A) NA PROVA 2: " + P2[0]);
						resultado2 = resultado(P1[0], P2[0]);
					}
					else if (nomeconsulta == nome[1])
					{
						Console.WriteLine("NOTA DO ALUNO(A) NA PROVA 1: " + P1[1]);
						Console.WriteLine("NOTA DO ALUNO(A) NA PROVA 2: " + P2[1]);
						resultado2 = resultado(P1[1], P2[1]);
					}
					else if (nomeconsulta == nome[2])
					{
						Console.WriteLine("NOTA DO ALUNO(A) NA PROVA 1: " + P1[2]);
						Console.WriteLine("NOTA DO ALUNO(A) NA PROVA 2: " + P2[2]);
						resultado2 = resultado(P1[2], P2[2]);
					}
					else if (nomeconsulta == nome[3])
					{
						Console.WriteLine("NOTA DO ALUNO(A) NA PROVA 1: " + P1[3]);
						Console.WriteLine("NOTA DO ALUNO(A) NA PROVA 2: " + P2[3]);
						resultado2 = resultado(P1[3], P2[3]);
					}
					break;

				case ("3"):
					Console.WriteLine("ATÉ A PRÓXIMA!...FINALIZANDO O SISTEMA");
					break;

				default:
					Console.WriteLine("OPÇÃO INDISPONÍVEL, FECHANO O SISTEMA...");
					break;

			}

			Console.WriteLine("-------------------------------------------------");
			Console.WriteLine("SEJA BEM VINDO AO SISTEMA ESCOLAR DE NOTAS - 2023");
			Console.WriteLine("-------------------------------------------------");
			Console.WriteLine("ESCOLHE UMA OPÇÃO DO MENU PARA CONTINUAR....");
			Console.WriteLine("[1] LANÇAR AS NOTAS DOS ALUNOS");
			Console.WriteLine("[2] CONSULTAR PONTUAÇÃO E STATUS DO ALUNO");
			Console.WriteLine("[3] FECHAR PROGRAMA DE NOTAS");
			menu = Console.ReadLine();

			Console.Clear();

			switch (menu)
			{
				case ("1"):
					for (int i = 0; i <= 3; i++)
					{
						Console.Write("DIGITE O NOME E O SOBRENOME DO ALUNO(A): ");
						nome[i] = Console.ReadLine();
						Console.WriteLine("DIGITE A SEGUIR A NOTA OBTIDA PELO ALUNO(A) NAS DUAS PROVAS");
						Console.WriteLine("PROVA 1");
						P1[i] = float.Parse(Console.ReadLine());
						Console.WriteLine("PROVA 2");
						P2[i] = float.Parse(Console.ReadLine());
						Console.Clear();
					}
					Console.Clear();
					break;

				case ("2"):
					Console.WriteLine("DIGITE O NOME DO ALUNO(A) PARA CONSULTAR O SEU STATUS: ");
					nomeconsulta = Console.ReadLine();
					if (nomeconsulta == nome[0])
					{
						Console.WriteLine("NOTA DO ALUNO(A) NA PROVA 1: " + P1[0]);
						Console.WriteLine("NOTA DO ALUNO(A) NA PROVA 2: " + P2[0]);
						resultado2 = resultado(P1[0], P2[0]);
						Console.WriteLine(resultado2);

					}
					else if (nomeconsulta == nome[1])
					{
						Console.WriteLine("NOTA DO ALUNO(A) NA PROVA 1: " + P1[1]);
						Console.WriteLine("NOTA DO ALUNO(A) NA PROVA 2: " + P2[1]);
						resultado2 = resultado(P1[1], P2[1]);
                        Console.WriteLine(resultado2);
                    }
					else if (nomeconsulta == nome[2])
					{
						Console.WriteLine("NOTA DO ALUNO(A) NA PROVA 1: " + P1[2]);
						Console.WriteLine("NOTA DO ALUNO(A) NA PROVA 2: " + P2[2]);
						resultado2 = resultado(P1[2], P2[2]);
                        Console.WriteLine(resultado2);
                    }
					else if (nomeconsulta == nome[3])
					{
						Console.WriteLine("NOTA DO ALUNO(A) NA PROVA 1: " + P1[3]);
						Console.WriteLine("NOTA DO ALUNO(A) NA PROVA 2: " + P2[3]);
						resultado2 = resultado(P1[3], P2[3]);
                        Console.WriteLine(resultado2);
                    }
					break;

				case ("3"):
					Console.WriteLine("ATÉ A PRÓXIMA!...FINALIZANDO O SISTEMA");
					break;

				default:
					Console.WriteLine("OPÇÃO INDISPONÍVEL, FECHANO O SISTEMA...");
					break;

			}



            Console.ReadLine();

        }

        

        static string resultado(float prova1, float prova2)
        {
            float result = prova1 + prova2;
            if (result < 12)
            {
                return ("ALUNO(A) REPROVADO!");
            }
            else
            {
                return ("ALUNO(A) APROVADO!");
            }

        }
    }   
}
