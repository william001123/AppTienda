
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Modelos
{
    public class clsRecepcionDetalleDom
    {

        public int IdRecepcionDetalle { get; set; }

        public int IdRecepcion { get; set; }

        public int IdProducto { get; set; }

        public double numCantidad { get; set; }

        public double numPrecio { get; set; }
    }
}