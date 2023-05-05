using System.ComponentModel.DataAnnotations;

namespace Datos.Entidades
{
    public class Proveedor
    {
        [Key]
        [Required]
        public int IdProveedor { get; set; }

        [StringLength(100)]
        public string strNIT { get; set; }

        [StringLength(200)]
        public string strNombre { get; set; }

        [StringLength(100)]
        public string strTelefono { get; set; }

        [StringLength(100)]
        public string strDireccion { get; set; }

        public List<Orden> Ordens { get; set; }
    }
}