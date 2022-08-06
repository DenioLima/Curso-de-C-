using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratamentos_de_erros
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            try
            {
                Console.WriteLine("Qual a sua idade?");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Sua idade é " + idade);
            }
            catch (Exception erro)
            {
                Console.WriteLine("Houve um erro, por favor  informe uma idade valida!");
                throw;
            }


            Console.ReadLine();
        }
        
    }
}
