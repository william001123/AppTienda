using System.ComponentModel.DataAnnotations;

namespace Datos.Entidades
{
    public class Movimiento
    {
        [Key]
        [Required]
        public int IdMovimiento { get; set; }

        [Required]
        public int IdTipoMovimiento { get; set; }

        [Required]
        public int IdTipoOrigen { get; set; }

        [Required]
        public int IdOrigen { get; set; }

        [Required]
        public int UserId { get; set; }        

        public TipoOrigen TipoOrigen { get; set; }

        public Usuario Usuario { get; set; }

        public TipoMovimiento TipoMovimiento { get; set; }

        public Venta Venta { get; set; }

        public Recepcion Recepcion { get; set; }

        public List<MovimientoDetalle> MovimientoDetalles { get; set; }
    }
}