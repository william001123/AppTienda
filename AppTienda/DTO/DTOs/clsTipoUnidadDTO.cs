
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DTO.DTOs
{
    public class clsTipoUnidadDTO
    {        
        public int IdTipoUnidad { get; set; }
        [Required]
        public string strTipoUnidad { get; set; }
    }
}