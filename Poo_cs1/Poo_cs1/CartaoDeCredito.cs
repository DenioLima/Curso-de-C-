using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_cs1
{
    public  class CartaoDeCredito
    {
        /* Agregação*/
        public string Numero { get; set; }

        public string DataDeValidade{ get; set; }

        public Cliente Cliente { get; set; }

    }
}
