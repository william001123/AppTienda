using Aplicacion.Interfaces;
using Aplicacion.Maestras;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using static Aplicacion.Maestras.MensajesBase;

namespace Aplicacion.Servicios
{
    public class clsRecepcionDetalleServ
        : IServicioObteIDEnc<clsRecepcionDetalleDom, int, List<clsRecepcionDetalleDom>>
    {
        private readonly IRepositorioObteIDEnc<clsRecepcionDetalleDom, int, List<clsRecepcionDetalleDom>> repo;
        private Excepcion excepcion = new Excepcion();

        public clsRecepcionDetalleServ(IRepositorioObteIDEnc<clsRecepcionDetalleDom, int, List<clsRecepcionDetalleDom>> _repo) 
        {
            repo = _repo;
        }

        public void Actualizar(clsRecepcionDetalleDom entidad)
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

        public clsRecepcionDetalleDom Insertar(clsRecepcionDetalleDom entidad)
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

        public clsRecepcionDetalleDom ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsRecepcionDetalleDom> ObtenerPorIDEnc(int entidadID)
        {
            return repo.ObtenerPorIDEnc(entidadID);
        }

        public List<clsRecepcionDetalleDom> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }
    }
}
