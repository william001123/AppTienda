
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DTO.DTOs
{
    public class clsRecepcionDTO
    {        
        public int IdRecepcion { get; set; }        
        public string strRecepcion { get; set; }
        [Required]
        public string strFactura { get; set; }
        [Required]
        public string strObservaciones { get; set; }
        [Required]
        public int IdOrden { get; set; }
        [Required]
        public string strEstado { get; set; }
    }
}