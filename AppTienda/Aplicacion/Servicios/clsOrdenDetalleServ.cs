using Aplicacion.Interfaces;
using Aplicacion.Maestras;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using static Aplicacion.Maestras.MensajesBase;

namespace Aplicacion.Servicios
{
    public class clsOrdenDetalleServ
        : IServicioObteIDEnc<clsOrdenDetalleDom, int, List<clsOrdenDetalleDom>>
    {
        private readonly IRepositorioObteIDEnc<clsOrdenDetalleDom, int, List<clsOrdenDetalleDom>> repo;
        private Excepcion excepcion = new Excepcion();

        public clsOrdenDetalleServ(IRepositorioObteIDEnc<clsOrdenDetalleDom, int, List<clsOrdenDetalleDom>> _repo) 
        {
            repo = _repo;
        }

        public void Actualizar(clsOrdenDetalleDom entidad)
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

        public clsOrdenDetalleDom Insertar(clsOrdenDetalleDom entidad)
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

        public clsOrdenDetalleDom ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsOrdenDetalleDom> ObtenerPorIDEnc(int entidadID)
        {
            return repo.ObtenerPorIDEnc(entidadID);
        }

        public List<clsOrdenDetalleDom> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }
    }
}
