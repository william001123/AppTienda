
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DTO.DTOs
{
    public class clsMovimientoDTO
    {        
        public int IdMovimiento { get; set; }
        [Required]
        public int IdTipoMovimiento { get; set; }
        [Required]
        public int IdTipoOrigen { get; set; }
        [Required]
        public int IdOrigen { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}