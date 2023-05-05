using System.ComponentModel.DataAnnotations;

namespace Datos.Entidades
{
    public class Producto
    {
        [Key]
        [Required]
        public int IdProducto { get; set; }

        [Required]
        public int IdCategoria { get; set; }

        [Required]
        public int IdTipoUnidad { get; set; }

        [Required]
        public double numCantidad { get; set; }

        [StringLength(200)]
        public string strNombre { get; set; }

        public byte[] bnReferencia { get; set; }

        public double numPrecio { get; set; }

        public List<VentaDetalle> VentaDetalles { get; set; }

        public List<OrdenDetalle> OrdenDetalles { get; set; }

        public Categoria Categoria { get; set; }

        public TipoUnidad TipoUnidad { get; set; }

        public List<RecepcionDetalle> RecepcionDetalles { get; set; }

        public List<MovimientoDetalle> MovimientoDetalles { get; set; }
    }
}