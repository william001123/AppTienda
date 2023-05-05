
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Modelos
{
    public class clsMovimientoDom
    {

        public int IdMovimiento { get; set; }

        public int IdTipoMovimiento { get; set; }

        public int IdTipoOrigen { get; set; }

        public int IdOrigen { get; set; }

        public int UserId { get; set; }
    }
}