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
            string nomeproduto = "";
            string categoria = "";
            string unidade = "";
            float precofornecedor = 0; 
            float precocusto = 0;
            float lucrodesejado = 0;



            Console.WriteLine("-------------------------");
            Console.WriteLine("   Gestão de Produtos");
            Console.WriteLine("-------------------------");

            Console.WriteLine("    Dados do Produto:");
            Console.WriteLine("-------------------------");
            Console.WriteLine("NOME DO PRODUTO :");
            nomeproduto = Console.ReadLine();
            Console.WriteLine("CATEGORIA DO PRODUTO :");
            categoria = Console.ReadLine();
            Console.WriteLine("UNIDADE DE MEDIDA DO PRODUTO :");
            unidade = Console.ReadLine();
            Console.WriteLine("PREÇO DE FORNECEDOR :");
            precofornecedor = float.Parse(Console.ReadLine());
            Console.WriteLine("PREÇO DE CUSTO :");
            precocusto = float.Parse(Console.ReadLine());
            Console.WriteLine("LUCRO DESEJADO(%) :");
            lucrodesejado = float.Parse(Console.ReadLine());
            Console.Clear();

            precodoproduto(precocusto,lucrodesejado,nomeproduto,categoria,unidade);




            Console.ReadLine();
        }
        static void precodoproduto(float preco, float lucro, string nome, string cat, string un)
        {
            float novopreco = ((preco * lucro) / 100) + preco;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("NOME DO PRODUTO-----" + nome);
            Console.WriteLine("CATEGORIA ---------------------" + cat);
            Console.WriteLine("UNIDADE DE MEDIDA--------------" + un);
        }   



    }   
}
