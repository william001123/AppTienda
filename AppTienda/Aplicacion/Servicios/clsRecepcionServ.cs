using Aplicacion.Interfaces;
using Aplicacion.Maestras;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using static Aplicacion.Maestras.MensajesBase;

namespace Aplicacion.Servicios
{
    public class clsRecepcionServ
        : IServicioActuaEstado<clsRecepcionDom, int, string>
    {
        private readonly IRepositorioActuaEstado<clsRecepcionDom, int, string> repo;
        private readonly IServicioInserList<clsMovimientoDom, int> ServMovimiento;
        private readonly IServicioMoviDetalle<clsMovimientoDetalleDom, int, List<clsMovimientoDetalleDom>> ServMovimientoDetalle;
        private readonly IServicioObteIDEnc<clsRecepcionDetalleDom, int, List<clsRecepcionDetalleDom>> ServRecepcionDetalle;

        private Excepcion excepcion = new Excepcion();

        public clsRecepcionServ(IRepositorioActuaEstado<clsRecepcionDom, int, string> _repo,
            IServicioInserList<clsMovimientoDom, int> _ServMovimiento,
            IServicioMoviDetalle<clsMovimientoDetalleDom, int, List<clsMovimientoDetalleDom>> _ServMovimientoDetalle,
            IServicioObteIDEnc<clsRecepcionDetalleDom, int, List<clsRecepcionDetalleDom>> _ServRecepcionDetalle)
        {
            repo = _repo;
            ServMovimiento = _ServMovimiento;
            ServMovimientoDetalle = _ServMovimientoDetalle;
            ServRecepcionDetalle = _ServRecepcionDetalle;
        }

        public void ActualizarEstado(int entidadID, string entidadEstado)
        {
            try
            {
                List<clsRecepcionDetalleDom> RecepcionDetalle = new List<clsRecepcionDetalleDom>();
                clsMovimientoDom Movimiento = new clsMovimientoDom();
                int IdTipoMovimiento = 2, IdTipoOrigen = 1, userId = 1;

                repo.ActualizarEstado(entidadID, entidadEstado);
                repo.SalvarTodo();

                if (entidadEstado == "Procesada")
                {

                    RecepcionDetalle = ServRecepcionDetalle.ObtenerPorIDEnc(entidadID);

                    Movimiento = ServMovimiento.Insertar(new clsMovimientoDom() { IdOrigen = entidadID, IdTipoMovimiento = IdTipoMovimiento, IdTipoOrigen = IdTipoOrigen, UserId = userId });

                    foreach (var item in RecepcionDetalle)
                    {
                        ServMovimientoDetalle.Insertar(new clsMovimientoDetalleDom()
                        {
                            IdProducto = item.IdProducto,
                            IdMovimiento = Movimiento.IdMovimiento,
                            numCantidad = item.numCantidad,
                            numPrecio = item.numPrecio,
                        }, IdTipoMovimiento);
                    }
                }

            }
            catch (Exception ex)
            {
                throw excepcion.Error(ex, Error.Actualizar.GetEnumDescription());
            }
        }

        public void Eliminar(int entidadID)
        {
            repo.Eliminar(entidadID);
            repo.SalvarTodo();
        }

        public clsRecepcionDom Insertar(clsRecepcionDom entidad)
        {
            try
            {
                string strRecepcion;
                clsRecepcionDom ultimo = new clsRecepcionDom();
                string fmt = "0000.##";

                ultimo = ObtenerUltimo();

                if (ultimo.IdRecepcion != 0)
                {

                    strRecepcion = ultimo.strRecepcion.Substring(2, 4);
                }
                else
                {
                    strRecepcion = "0000";
                }
                strRecepcion = "RP" + (Convert.ToInt32(strRecepcion) + 1).ToString(fmt);

                entidad.strRecepcion = strRecepcion;

                var result = repo.Insertar(entidad);
                repo.SalvarTodo();
                return result;
            }
            catch (Exception ex)
            {
                throw excepcion.Error(ex, Error.Insertar.GetEnumDescription());
            }
        }

        public clsRecepcionDom ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsRecepcionDom> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }

        public clsRecepcionDom ObtenerUltimo()
        {
            return repo.ObtenerUltimo();
        }
    }
}
