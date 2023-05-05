
using System.ComponentModel.DataAnnotations;

namespace DTO.DTOs
{
    public class clsEmpleadoDTO
    {        
        public int IdEmpleado { get; set; }
        [Required]
        public string strDocumento { get; set; }
        [Required]
        public string strNombre { get; set; }

    }
}