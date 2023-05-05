using System.ComponentModel.DataAnnotations;

namespace Datos.Entidades
{
    public class RecepcionDetalle
    {
        [Key]
        [Required]
        public int IdRecepcionDetalle { get; set; }

        [Required]
        public int IdRecepcion { get; set; }

        [Required]
        public int IdProducto { get; set; }

        public double numCantidad { get; set; }

        public double numPrecio { get; set; }

        public Recepcion Recepcion { get; set; }

        public Producto Producto { get; set; }
    }
}