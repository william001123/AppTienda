using Aplicacion.Interfaces;
using Aplicacion.Maestras;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using static Aplicacion.Maestras.MensajesBase;

namespace Aplicacion.Servicios
{
    public class clsTipoOrigenServ
        : IServicioBase<clsTipoOrigenDom, int>
    {
        private readonly IRepositorioBase<clsTipoOrigenDom, int> repo;
        private Excepcion excepcion = new Excepcion();

        public clsTipoOrigenServ(IRepositorioBase<clsTipoOrigenDom, int> _repo) 
        {
            repo = _repo;
        }

        public void Actualizar(clsTipoOrigenDom entidad)
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

        public clsTipoOrigenDom Insertar(clsTipoOrigenDom entidad)
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

        public clsTipoOrigenDom ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsTipoOrigenDom> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }
    }
}
