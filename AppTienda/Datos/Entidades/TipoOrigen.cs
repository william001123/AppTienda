using System.ComponentModel.DataAnnotations;

namespace Datos.Entidades
{
    public class TipoOrigen
    {
        [Key]
        [Required]
        public int IdTipoOrigen { get; set; }

        [StringLength(200)]
        public string strTipoOrigen { get; set; }

        public List<Movimiento> Movimientos { get; set; }
    }
}