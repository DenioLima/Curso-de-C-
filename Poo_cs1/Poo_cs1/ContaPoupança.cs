using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_cs1
{
    public class ContaPoupança : Conta
    {
        /*Trabalahndo com herança*/
        public ContaPoupança(int numero, double limite) : base(numero,limite)
        {

        }
        public void MostrarNumeroConta()
        {
            Console.WriteLine("O seu numero da conta é  "+ this.Numero);
        }
    }
}
