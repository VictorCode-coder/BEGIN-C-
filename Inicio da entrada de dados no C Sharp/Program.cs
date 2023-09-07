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
            string[] nomealuno = {"ANNA", "JOÃO", "PAULO","JULIA"};
            float Prova1 = 0;
            float Prova2 = 0;
            float notasatividades = 0;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("SEJA BEM VINDO AO DIÁRIO DE NOTAS DA ESCOLA");
            Console.WriteLine("-------------------------------------------");


            Console.WriteLine(nomealuno[2]);
            Console.WriteLine("NOTA DA PROVA 1:");
            Prova1 = float.Parse(Console.ReadLine());
            Console.WriteLine("NOTA DA PROVA 2:");
            Prova2 = float.Parse(Console.ReadLine());
            Console.WriteLine("NOTA DAS ATIVIDADES EM SALA");
            notasatividades = float.Parse(Console.ReadLine());
            
            float valortotal = notafinal(Prova1, Prova2, notasatividades);
            Console.WriteLine("A NOTA FINAL DO ALUNO É: " +  valortotal);   

            Console.ReadLine();
        }
        static float notafinal(float P1, float P2, float NA)
        {  
            float total = P1 + P2 + NA;
            return total;







            
        }

        

    }   
}
