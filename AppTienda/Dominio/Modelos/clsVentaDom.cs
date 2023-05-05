
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Modelos
{
    public class clsVentaDom
    {

        public int IdVenta { get; set; }

        public string strVenta { get; set; }

        public DateTime dtFecha { get; set; }

        public double numTotal { get; set; }

        public string strEstado { get; set; }
    }
}