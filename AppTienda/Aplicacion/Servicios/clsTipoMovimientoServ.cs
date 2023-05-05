using Aplicacion.Interfaces;
using Aplicacion.Maestras;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using static Aplicacion.Maestras.MensajesBase;

namespace Aplicacion.Servicios
{
    public class clsTipoMovimientoServ
        : IServicioBase<clsTipoMovimientoDom, int>
    {
        private readonly IRepositorioBase<clsTipoMovimientoDom, int> repo;
        private Excepcion excepcion = new Excepcion();

        public clsTipoMovimientoServ(IRepositorioBase<clsTipoMovimientoDom, int> _repo) 
        {
            repo = _repo;
        }

        public void Actualizar(clsTipoMovimientoDom entidad)
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

        public clsTipoMovimientoDom Insertar(clsTipoMovimientoDom entidad)
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

        public clsTipoMovimientoDom ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsTipoMovimientoDom> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }
    }
}
