using System.ComponentModel.DataAnnotations;

namespace Datos.Entidades
{
    public class OrdenDetalle
    {
        [Key]
        [Required]
        public int IdOrdenDetalle { get; set; }

        [Required]
        public int IdOrden { get; set; }

        [Required]
        public int IdProducto { get; set; }

        public double numCantidad { get; set; }

        public double numPrecio { get; set; }

        public Orden Orden { get; set; }

        public Producto Producto { get; set; }
    }
}