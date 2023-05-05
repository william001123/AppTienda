using System.ComponentModel.DataAnnotations;

namespace Datos.Entidades
{
    public class Recepcion
    {
        [Key]
        [Required]
        public int IdRecepcion { get; set; }

        [StringLength(200)]
        public string strRecepcion { get; set; }
        [StringLength(200)]
        public string strFactura { get; set; }

        [StringLength(200)]
        public string strObservaciones { get; set; }

        [Required]
        public int IdOrden { get; set; }

        [StringLength(200)]
        public string strEstado { get; set; }

        public Movimiento Movimiento { get; set; }

        public List<RecepcionDetalle> RecepcionDetalles { get; set; }

        public Orden Orden { get; set; }
    }
}