using Aplicacion.Interfaces;
using Aplicacion.Maestras;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using static Aplicacion.Maestras.MensajesBase;

namespace Aplicacion.Servicios
{
    public class clsEmpleadoServ
        : IServicioBase<clsEmpleadoDom, int>
    {
        private readonly IRepositorioBase<clsEmpleadoDom, int> repo;
        private Excepcion excepcion = new Excepcion();

        public clsEmpleadoServ(IRepositorioBase<clsEmpleadoDom, int> _repo) 
        {
            repo = _repo;
        }

        public void Actualizar(clsEmpleadoDom entidad)
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

        public clsEmpleadoDom Insertar(clsEmpleadoDom entidad)
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

        public clsEmpleadoDom ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsEmpleadoDom> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }
    }
}
