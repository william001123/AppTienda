
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DTO.DTOs
{
    public class clsOrdenDetalleDTO
    {        
        public int IdOrdenDetalle { get; set; }
        [Required]
        public int IdOrden { get; set; }
        [Required]
        public int IdProducto { get; set; }
        [Required]
        public double numCantidad { get; set; }
        [Required]
        public double numPrecio { get; set; }
    }
}