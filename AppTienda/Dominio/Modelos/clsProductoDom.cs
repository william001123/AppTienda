
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Modelos
{
    public class clsProductoDom
    {
        public int IdProducto { get; set; }

        public int IdCategoria { get; set; }

        public int IdTipoUnidad { get; set; }

        public double numCantidad { get; set; }

        public string strNombre { get; set; }

        public byte[] bnReferencia { get; set; }

        public double numPrecio { get; set; }
    }
}