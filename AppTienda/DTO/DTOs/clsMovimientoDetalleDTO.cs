
using System.ComponentModel.DataAnnotations;

namespace DTO.DTOs
{
    public class clsMovimientoDetalleDTO
    {        
        public int IdMovimientoDetalle { get; set; }
        [Required]
        public int IdMovimiento { get; set; }
        [Required]
        public int IdProducto { get; set; }
        [Required]
        public double numCantidad { get; set; }
        [Required]
        public double numPrecio { get; set; }
    }
}