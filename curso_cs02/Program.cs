using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_cs02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 60;
            int c= 80;
          if (a >= c || c > b)
	       {
              Console.WriteLine("verdade!");
	       }
          else if (a < c && b > a)
            {
                Console.WriteLine("Verdade,verdadeira!");
            }
          else
	       {
              Console.WriteLine("Mentira!");
	       }

          
            Console.WriteLine("Digite sua idade.");
            int idade = int.Parse(Console.ReadLine());
            if(idade <= 12)
              { 
                Console.WriteLine("Você é uma criança!");
              }  
            else if(idade > 12 && idade <= 18)
              {
                Console.WriteLine("Você é Aborrecente!");
              } 
            else if((idade > 18 && idade <= 25))
              {
                Console.WriteLine("Você esta na hora de arrumar um serviço!");
              }  
            else if ((idade > 25 && idade <= 50))
              {
                Console.WriteLine("Você está ficando velho!");
              }  
            else if(((idade > 50 && idade <= 70)))
              {
                Console.WriteLine("Você já é um ancião!");                
              } 
            else if (((idade > 70)))
              {
                Console.WriteLine("Está na hora de voltar para casa!");
              } 
            Console.ReadLine();
        }
    }
}
