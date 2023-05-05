
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DTO.DTOs
{
    public class clsTipoOrigenDTO
    {        
        public int IdTipoOrigen { get; set; }
        [Required]
        public string strTipoOrigen { get; set; }
    }
}