using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_cs1
{
    public class GerenteAgencia : Gerente
    {
        public override void Reajustar()
        {
            this.Salario += 1500;
        }
    }
}
