using System.ComponentModel.DataAnnotations;

namespace Datos.Entidades
{
    public class Usuario
    {
        [Key]
        [Required]
        public int UserId { get; set; }

        [StringLength(200)]
        public string strUserName { get; set; }

        [StringLength(200)]
        public string strContraseña { get; set; }

        [Required]
        public int IdEmpleado { get; set; }

        public List<Movimiento> Movimientos { get; set; }

        public Empleado Empleado { get; set; }
    }
}