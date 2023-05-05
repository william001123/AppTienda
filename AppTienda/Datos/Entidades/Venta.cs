using System.ComponentModel.DataAnnotations;

namespace Datos.Entidades
{
    public class Venta
    {
        [Key]
        [Required]
        public int IdVenta { get; set; }

        [StringLength(200)]
        public string strVenta { get; set; }

        public DateTime dtFecha { get; set; }

        public double numTotal { get; set; }

        [Required]
        public int UserId { get; set; }

        [StringLength(200)]
        public string strEstado { get; set; }

        public List<VentaDetalle> VentaDetalles { get; set; }

        public Movimiento Movimiento { get; set; }
    }
}