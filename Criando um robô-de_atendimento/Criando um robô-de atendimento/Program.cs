using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criando_um_robô_de_atendimento
{
    class Program
    {
        static void Main(string[] args)
        {
            //fazendo um robô de atendimento//
            int opcao = 0;

            Console.WriteLine("                          Digete a opção desejada                                   ");
            Console.WriteLine("                          ***************************                                     ");
            Console.WriteLine("                          1 - Desbloqueio do cartão                                     ");
            Console.WriteLine("                          ***************************                                    ");
            Console.WriteLine("                          2 - Bloqueio do cartão                                  ");
            Console.WriteLine("                          ***************************                                     ");
            Console.WriteLine("                          3 - Falar com atendente                                   ");
            Console.WriteLine("                          ***************************                                   ");
            Console.WriteLine("                          4 - Sair do sitema                                  ");
            Console.WriteLine("                          ***************************                                    ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    {
                        Console.WriteLine("Cartão desbloqueado com sucesso!");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Cartão bloqueado com sucesso!");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Ola, em que posso ajudar?");
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("                        ****************                                   ");
                        Console.WriteLine("                          Volte sempre!                                 ");
                        Console.WriteLine("                        ****************                                   ");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opção informada não existe!");
                        break;
                    }

            }

            Console.ReadLine();
        }
    }
}
