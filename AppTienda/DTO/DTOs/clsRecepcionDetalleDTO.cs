
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DTO.DTOs
{
    public class clsRecepcionDetalleDTO
    {        
        public int IdRecepcionDetalle { get; set; }
        [Required]
        public int IdRecepcion { get; set; }
        [Required]
        public int IdProducto { get; set; }
        [Required]
        public double numCantidad { get; set; }
        [Required]
        public double numPrecio { get; set; }
    }
}