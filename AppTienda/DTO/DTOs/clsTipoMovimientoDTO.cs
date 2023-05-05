
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DTO.DTOs
{
    public class clsTipoMovimientoDTO
    {        
        public int IdTipoMovimiento { get; set; }
        [Required]
        public string strTipoMovimiento { get; set; }
    }
}