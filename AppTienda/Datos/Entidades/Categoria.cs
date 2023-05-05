using System.ComponentModel.DataAnnotations;

namespace Datos.Entidades
{
    public class Categoria
    {
        [Key]
        [Required]
        public int IdCategoria { get; set; }

        [StringLength(200)]
        [Required]
        public string strCategoria { get; set; }

        public List<Producto> Productos { get; set; }

    }
}