using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Entidades
{
    public class Empleado
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int IdEmpleado { get; set; }

        [StringLength(200)]
        public string strDocumento { get; set; }

        [StringLength(200)]
        public string strNombre { get; set; }

        public Usuario Usuario { get; set; }
    }
}
