using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Venta
    {
        public int ID_Venta { get; set; }
        public int ID_Cliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
