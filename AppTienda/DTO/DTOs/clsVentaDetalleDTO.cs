
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DTO.DTOs
{
    public class clsVentaDetalleDTO
    {        
        public int IdVentaDetalle { get; set; }
        [Required]
        public int IdVenta { get; set; }
        [Required]
        public int IdProducto { get; set; }
        [Required]
        public double numCantidad { get; set; }
        [Required]
        public double numPrecio { get; set; }
    }
}