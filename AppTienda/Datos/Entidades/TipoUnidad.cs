using System.ComponentModel.DataAnnotations;

namespace Datos.Entidades
{
    public class TipoUnidad
    {
        [Key]
        [Required]
        public int IdTipoUnidad { get; set; }

        [StringLength(200)]
        public string strTipoUnidad { get; set; }

        public List<Producto> Productos { get; set; }
    }
}