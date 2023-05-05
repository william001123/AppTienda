
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Modelos
{
    public class clsRecepcionDom
    {

        public int IdRecepcion { get; set; }

        public string strRecepcion { get; set; }
        public string strFactura { get; set; }

        public string strObservaciones { get; set; }

        public int IdOrden { get; set; }

        public string strEstado { get; set; }
    }
}