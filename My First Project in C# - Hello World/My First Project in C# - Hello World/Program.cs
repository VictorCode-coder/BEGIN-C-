﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project_in_C____Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Maneira 1 de criar uma variável: usando o var
           Tipos de var iniciais : var,int,float(f no final),bool,string,char
           Maneira 2: Já indincado o tipo da variável
            Maneira3: Utilizando o DYNAMIC, em que você consegue guardar diferentes tipos de dados nela ao longo o código*/

            var boasvindas = "Olá, Seja bem vindo e feliz Páscoa";
            int WW2 = 1942;
            string corfav = "Amarelo";
            float VF1 = 294.48f;
            bool WW2_ocorreu = true;
            dynamic nome = "João";


            /*\n ou Console.WriteLine pula uma linha
            Console.Write escreve na tela*/

            Console.WriteLine(boasvindas);
            Console.WriteLine("Meu nome é João Victor!");
            Console.WriteLine(WW2);
            Console.WriteLine(corfav);
            Console.WriteLine(VF1);
            Console.WriteLine(WW2_ocorreu);
            Console.WriteLine(nome);

            VF1 = 2323.45f;
            corfav = "Roxo";
            nome = 4.5;

            Console.WriteLine(nome);

            //Console.ReadLine ele espera que o user digite algo ou clique em enter para continuar.
            Console.ReadLine();

        }
    }
}   
