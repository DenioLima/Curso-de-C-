using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*começando a trabalhar com array*/
            string[] familia = new string[] { "Jadir","Lica","Denio","Diego"};
            Console.WriteLine("Qual é o mais jovem da familia?");
            familia[2]= "Denio bonitão";
            Console.WriteLine(familia[2]);
            familia[3]="Diego lata ruim";
            int[] idade = {60,55,25,45};
            Console.WriteLine("Qual da familia tem andado mais no minerio?");
            Console.WriteLine( familia[3] + " Ele tem " + idade[3] + " anos");
            Console.ReadLine();
        }
    }
}
