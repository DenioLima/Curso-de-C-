using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazendo__calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int con = 0; con <= 10; con++)
            {
                Console.WriteLine(con);
            } 
 
            int numero ;
            Console.WriteLine("Digite um numero!");
            numero = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
			{
                int total = numero * i;
                Console.WriteLine( numero + "x" + i + "=" + total);
			}
            Console.ReadLine();   
        }
        
    }
}
