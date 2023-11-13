using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Devolucion
    {
        public int ID_Devolucion { get; set; }
        public int ID_Venta { get; set; }
        public int ID_Producto { get; set; }
        public int CantidadDevuelta { get; set; }
        public string Motivo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
