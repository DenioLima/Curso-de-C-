using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_cs1
{
    public abstract class Conta : IConta
    {

        /*Contrutores*/
        public Conta( int numero, double limite)
        {
            this.Numero = numero;
            this.Limite = limite;
            Conta.TotalContasCriasdas++;
        }

        /*propriedades*/
        protected double Saldo { get; set; }

        public double Limite{ get;  set; }

        public int Numero { get;  set; }

        public static int TotalContasCriasdas { get; set; }

        /*Metodos*/
        public void Depositar(double valor )
        {
            this.Saldo += valor;

        }
        public void AdicionarLimite( double valor)
        {
            this.Limite = valor;
        }

        public static int NovoTotalContasCriadas()
        {
            return Conta.TotalContasCriasdas + 1;
        }
        public bool Sacar(double valor)
        {
            double SaldoDisponivel = this.ConsultaSaldoDisponivel();

            if (valor > SaldoDisponivel)
            {
                Console.WriteLine("Saque e saldo indisponivel!");
                return false;
            }
            this.Saldo -= valor;
            return true;
        }
        public double ConsultaSaldoDisponivel()
        {
            return this.Saldo + this.Limite;
        }



    }   

}
