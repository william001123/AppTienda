
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DTO.DTOs
{
    public class clsVentaDTO
    {        
        public int IdVenta { get; set; }        
        public string strVenta { get; set; }
        [Required]
        public DateTime dtFecha { get; set; }
        [Required]
        public double numTotal { get; set; }
        [Required]
        public string strEstado { get; set; }
    }
}