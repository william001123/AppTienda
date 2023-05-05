using System.ComponentModel.DataAnnotations;

namespace Datos.Entidades
{
    public class Orden
    {
        [Key]
        [Required]
        public int IdOrden { get; set; }

        [Required]
        public int IdProveedor { get; set; }

        [StringLength(200)]
        public string strOrden { get; set; }

        public DateTime dtFechaOrden { get; set; }

        public DateTime dtFechaEntrega { get; set; }

        public double numTotal { get; set; }

        [Required]
        public int UserId { get; set; }

        [StringLength(200)]
        public string strEstado { get; set; }

        public List<OrdenDetalle> OrdenDetalles { get; set; }

        public Proveedor Proveedor { get; set; }

        public List<Recepcion> Recepcions { get; set; }
    }
}