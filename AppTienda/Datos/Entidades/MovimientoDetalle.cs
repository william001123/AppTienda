using System.ComponentModel.DataAnnotations;

namespace Datos.Entidades
{
    public class MovimientoDetalle
    {
        [Key]
        [Required]
        public int IdMovimientoDetalle { get; set; }

        [Required]
        public int IdMovimiento { get; set; }

        [Required]
        public int IdProducto { get; set; }

        public double numCantidad { get; set; }

        public double numPrecio { get; set; }

        public Movimiento Movimiento { get; set; }

        public Producto Producto { get; set; }
    }
}