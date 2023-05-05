
using System.ComponentModel.DataAnnotations;

namespace DTO.DTOs
{
    public class clsProductoDTO
    {        
        public int IdProducto { get; set; }
        [Required]
        public int IdCategoria { get; set; }
        [Required]
        public int IdTipoUnidad { get; set; }
        [Required]
        public double numCantidad { get; set; }
        [Required]
        public string strNombre { get; set; }
        [Required]
        public byte[] bnReferencia { get; set; }
        [Required]
        public double numPrecio { get; set; }
    }
}