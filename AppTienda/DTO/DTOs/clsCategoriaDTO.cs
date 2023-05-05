
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DTO.DTOs
{
    public class clsCategoriaDTO
    {        
        public int IdCategoria { get; set; }
        [Required]
        public string? strCategoria { get; set; }

    }
}