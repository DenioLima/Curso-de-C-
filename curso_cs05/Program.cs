using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_cs05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
            Console.WriteLine("Acabou a contagem!");
            rep();
            rep2();
            Console.ReadLine();

        }
        static void rep()
        {
            string[] familia = { "Jadir","Lica","Denio","Diego" };
            foreach(string family in familia)
            {
                Console.WriteLine(family);
            }

        }
        static void rep2()
        {
            string[] familia = { "Jadir","Lica","Denio","Diego" };
            for(int con = 0; con < 10; con++) 
            { 
                Console.WriteLine(con);
            }
            for(int con = 0; con < familia.Length; con++)
            {
                Console.WriteLine(familia [con]);
            }
        }
    }
} 
