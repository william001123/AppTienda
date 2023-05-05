
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DTO.DTOs
{
    public class clsOrdenDTO
    {        
        public int IdOrden { get; set; }
        [Required]
        public int IdProveedor { get; set; }
        
        public string strOrden { get; set; }
        [Required]
        public DateTime dtFechaOrden { get; set; }
        [Required]
        public DateTime dtFechaEntrega { get; set; }
        [Required]
        public double numTotal { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string strEstado { get; set; }
    }
}