
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Modelos
{
    public class clsOrdenDom
    {

        public int IdOrden { get; set; }

        public int IdProveedor { get; set; }

        public string strOrden { get; set; }

        public DateTime dtFechaOrden { get; set; }

        public DateTime dtFechaEntrega { get; set; }

        public double numTotal { get; set; }

        public int UserId { get; set; }

        public string strEstado { get; set; }
    }
}