
namespace Dominio.Modelos
{
    public class clsMovimientoDetalleDom
    {

        public int IdMovimientoDetalle { get; set; }

        public int IdMovimiento { get; set; }

        public int IdProducto { get; set; }

        public double numCantidad { get; set; }

        public double numPrecio { get; set; }
    }
}