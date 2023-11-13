using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Inventario
    {
        public int ID_Inventario { get; set; }
        public int ID_Producto { get; set; }
        public int StockActual { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
