
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Modelos
{
    public class clsOrdenDetalleDom
    {

        public int IdOrdenDetalle { get; set; }

        public int IdOrden { get; set; }

        public int IdProducto { get; set; }

        public double numCantidad { get; set; }

        public double numPrecio { get; set; }
    }
}