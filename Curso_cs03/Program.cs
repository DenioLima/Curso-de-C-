
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_cs03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lurdinha();
            Lurdinha();
            Lurdinha();
            Console.WriteLine("Quanto está valendo a nova camisa do cruzeirão cabuloso?");
            string valor = Console.ReadLine();
            Console.WriteLine("Esse é o valor cheio" + valor + "R$");
            //CamisaCruzeiro(300,"com desconto");
            Console.WriteLine("E com desconto para socio?");
            string desconto = Console.ReadLine();
            //CamisaCruzeiro(255, "sem desconto");
            Console.ReadLine();
        }

        static void Lurdinha()
        {
            Console.WriteLine("Chupa lurdinha!");
            Console.WriteLine("time sem tri!");
            Console.WriteLine("Chacotão");
            
        }
        static void CamisaCruzeiro(int preco,string des )
        {
            /*Console.WriteLine(desconto);*/
            Console.WriteLine(preco + des);

        }
    }
}
