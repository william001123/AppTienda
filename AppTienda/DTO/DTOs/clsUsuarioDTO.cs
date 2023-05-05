
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DTO.DTOs
{
    public class clsUsuarioDTO
    {        
        public int UserId { get; set; }
        [Required]
        public string strUserName { get; set; }
        [Required]
        public string strContraseña { get; set; }
        [Required]
        public int IdEmpleado { get; set; }
    }
}