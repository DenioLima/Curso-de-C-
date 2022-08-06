using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_cs1
{
    public abstract class Funcionario
    {
        /*Trabalhando com Classes abstradas e Polimorfismo*/
        public string Nome { get; set; }
        public double Salario { get; protected set; }
        public abstract void Reajustar();

        public void SalarioPadrao(double salario)
        {
            this.Salario = salario;
        }
    }
}
