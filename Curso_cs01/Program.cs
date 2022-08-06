using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int é para variaveis inteiras ex:0,1,2,15,110,...
            //float é para variaveis com casas decimais, e tem q colocar um f no final ex:1.5f,10.5f,115.6f,...
            //string é para variaveis com palavras ou textos ex:Denio,Gu,Lurdinha,...
            //bool é para variaveis que recebem verdadeioro ou falso ex:True, false
            //char é para variaveis que recebem so um letra ex:a,b,A,B,...

            int dtNascimento = 1988;
            float altura = 1.70f;
            string nome = "Denio";
            bool masculino = true;

            Console.WriteLine("Chupa lurdinha!");
            Console.WriteLine("Time sem tri!");
            Console.WriteLine(dtNascimento);
            Console.WriteLine(altura);
            Console.WriteLine(nome);
            Console.WriteLine(masculino);

            //Para redefinir uma variavel é so caolocar o nome e oq ela recebe,sem colocar o tipo
            dtNascimento = 1995;
            nome = "Diego";
            Console.WriteLine(dtNascimento);
            Console.WriteLine(nome);
            //Posso mudar o tipo da minha variavel declarando de outra forma, declarando como dynamic

            dynamic maiorInglaterra = "Chelsea";
            Console.WriteLine(maiorInglaterra);
            maiorInglaterra = 7;
            Console.WriteLine(maiorInglaterra);

            //Quando quiser criar uma variavel que seja imutavel, é so criar como const
            const string cabuloso = "Cruzeiro";
            Console.WriteLine(cabuloso);

            //Para interagir com o usuario é so usar o console.ReadLine
            string menor = "";
            Console.WriteLine("Qual é o menor time ingles?");
            menor = Console.ReadLine();
            Console.Write("O menor time da Inglaterra é o ");
            Console.WriteLine(menor);

            //Usando operadores aritimeticos no C#
            int soma = 5 + 9;
            int subtracao = 15 - 9;
            int multiplicacao = 5 * 6;
            int divisao = 6 / 2; //Sempre que for divisão de e o resultado for numero inteiro, se usa int
            float divisao2 = 5f / 2;// Quando o resultado da divisão, não for inteiro se usa float
            Console.WriteLine(soma);
            Console.WriteLine(subtracao);
            Console.WriteLine(multiplicacao);
            Console.WriteLine(divisao);
            Console.WriteLine(divisao2);

            Console.ReadLine();


        }
    }
}
