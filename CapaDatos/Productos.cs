using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Productos
    {
        public int ID_Producto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int ID_Proveedor { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaLote { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
