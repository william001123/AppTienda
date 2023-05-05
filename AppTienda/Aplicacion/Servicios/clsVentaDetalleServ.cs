using Aplicacion.Interfaces;
using Aplicacion.Maestras;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using static Aplicacion.Maestras.MensajesBase;

namespace Aplicacion.Servicios
{
    public class clsVentaDetalleServ
        : IServicioObteIDEnc<clsVentaDetalleDom, int, List<clsVentaDetalleDom>>
    {
        private readonly IRepositorioObteIDEnc<clsVentaDetalleDom, int, List<clsVentaDetalleDom>> repo;
        private Excepcion excepcion = new Excepcion();

        public clsVentaDetalleServ(IRepositorioObteIDEnc<clsVentaDetalleDom, int, List<clsVentaDetalleDom>> _repo) 
        {
            repo = _repo;
        }

        public void Actualizar(clsVentaDetalleDom entidad)
        {
            try
            {
                repo.Actualizar(entidad);
                repo.SalvarTodo();
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

        public clsVentaDetalleDom Insertar(clsVentaDetalleDom entidad)
        {
            try
            {
                var result = repo.Insertar(entidad);
                repo.SalvarTodo();
                return result;
            }
            catch (Exception ex)
            {
                throw excepcion.Error(ex, Error.Insertar.GetEnumDescription());
            }
        }

        public clsVentaDetalleDom ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsVentaDetalleDom> ObtenerPorIDEnc(int entidadID)
        {
            return repo.ObtenerPorIDEnc(entidadID);
        }

        public List<clsVentaDetalleDom> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }
    }
}
