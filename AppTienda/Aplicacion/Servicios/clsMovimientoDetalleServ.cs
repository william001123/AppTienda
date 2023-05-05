using Aplicacion.Interfaces;
using Aplicacion.Maestras;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using static Aplicacion.Maestras.MensajesBase;

namespace Aplicacion.Servicios
{
    public class clsMovimientoDetalleServ
        : IServicioMoviDetalle<clsMovimientoDetalleDom, int, List<clsMovimientoDetalleDom>>
    {
        private readonly IRepositorioMoviDetalle<clsMovimientoDetalleDom, int, List<clsMovimientoDetalleDom>> repo;
        private readonly IServicioProducto<clsProductoDom, int, double> ServProducto;
        private Excepcion excepcion = new Excepcion();

        public clsMovimientoDetalleServ(IRepositorioMoviDetalle<clsMovimientoDetalleDom, int, List<clsMovimientoDetalleDom>> _repo,
            IServicioProducto<clsProductoDom, int, double> _ServProducto) 
        {
            repo = _repo;
            ServProducto = _ServProducto;
        }

        public clsMovimientoDetalleDom Insertar(clsMovimientoDetalleDom entidad, int TipoMovimiento)
        {
            try
            {
                var result = repo.Insertar(entidad);
                repo.SalvarTodo();

                clsProductoDom Producto = new clsProductoDom();
                double numCantidad = 0.00;

                Producto = ServProducto.ObtenerPorID(entidad.IdProducto);

                numCantidad = Producto.numCantidad;

                if (TipoMovimiento == 1)
                {
                    numCantidad = numCantidad - entidad.numCantidad;
                }
                else if (TipoMovimiento == 2)
                {
                    numCantidad = numCantidad + entidad.numCantidad;
                }

                ServProducto.ActualizarCant(entidad.IdProducto, numCantidad);

                return result;                

            }
            catch (Exception ex)
            {
                throw excepcion.Error(ex, Error.Insertar.GetEnumDescription());
            }
        }

        public clsMovimientoDetalleDom ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsMovimientoDetalleDom> ObtenerPorIDEnc(int entidadID)
        {
            return repo.ObtenerPorIDEnc(entidadID);
        }

        public List<clsMovimientoDetalleDom> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }
    }
}
