using Aplicacion.Interfaces;
using Aplicacion.Maestras;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using static Aplicacion.Maestras.MensajesBase;

namespace Aplicacion.Servicios
{
    public class clsTipoUnidadServ
        : IServicioBase<clsTipoUnidadDom, int>
    {
        private readonly IRepositorioBase<clsTipoUnidadDom, int> repo;
        private Excepcion excepcion = new Excepcion();

        public clsTipoUnidadServ(IRepositorioBase<clsTipoUnidadDom, int> _repo) 
        {
            repo = _repo;
        }

        public void Actualizar(clsTipoUnidadDom entidad)
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

        public clsTipoUnidadDom Insertar(clsTipoUnidadDom entidad)
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

        public clsTipoUnidadDom ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsTipoUnidadDom> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }
    }
}
