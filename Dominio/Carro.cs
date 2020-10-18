using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carro
    {
        public SqlMoney ImporteTotal { get; set; }
        public int CantidadItems { get; set; }

       public Carro()
        {
            ImporteTotal = 0;
            CantidadItems = 0;

        }
    }
}
