using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_cs1
{
    public interface IConta
    {
        void Depositar(double valor);
        void AdicionarLimite(double valor);
        bool Sacar(double valor);
        double ConsultaSaldoDisponivel();

    }
}
