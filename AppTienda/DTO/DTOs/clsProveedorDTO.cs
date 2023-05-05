
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace DTO.DTOs
{
    public class clsProveedorDTO
    {        
        public int IdProveedor { get; set; }
        [Required]
        public string strNIT { get; set; }
        [Required]
        public string strNombre { get; set; }
        [Required]
        public string strTelefono { get; set; }
        [Required]
        public string strDireccion { get; set; }
    }
}