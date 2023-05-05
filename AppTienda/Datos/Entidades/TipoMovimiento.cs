using System.ComponentModel.DataAnnotations;

namespace Datos.Entidades
{
    public class TipoMovimiento
    {
        [Key]
        [Required]
        public int IdTipoMovimiento { get; set; }

        [StringLength(200)]
        public string strTipoMovimiento { get; set; }

        public List<Movimiento> Movimientos { get; set; }

    }
}