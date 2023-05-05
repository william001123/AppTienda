using System.ComponentModel.DataAnnotations;

namespace Datos.Entidades
{
    public class VentaDetalle
    {
        [Key]
        [Required]
        public int IdVentaDetalle { get; set; }

        [Required]
        public int IdVenta { get; set; }

        [Required]
        public int IdProducto { get; set; }

        public double numCantidad { get; set; }

        public double numPrecio { get; set; }

        public Venta Venta { get; set; }

        public Producto Producto { get; set; }
    }
}