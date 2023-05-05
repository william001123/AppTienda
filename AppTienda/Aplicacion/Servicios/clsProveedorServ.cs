using Aplicacion.Interfaces;
using Aplicacion.Maestras;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using static Aplicacion.Maestras.MensajesBase;

namespace Aplicacion.Servicios
{
    public class clsProveedorServ
        : IServicioBase<clsProveedorDom, int>
    {
        private readonly IRepositorioBase<clsProveedorDom, int> repo;
        private Excepcion excepcion = new Excepcion();

        public clsProveedorServ(IRepositorioBase<clsProveedorDom, int> _repo) 
        {
            repo = _repo;
        }

        public void Actualizar(clsProveedorDom entidad)
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

        public clsProveedorDom Insertar(clsProveedorDom entidad)
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

        public clsProveedorDom ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsProveedorDom> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }
    }
}
