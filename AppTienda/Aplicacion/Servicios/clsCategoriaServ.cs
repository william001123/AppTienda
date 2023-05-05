using Aplicacion.Interfaces;
using Aplicacion.Maestras;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using static Aplicacion.Maestras.MensajesBase;

namespace Aplicacion.Servicios
{
    public class clsCategoriaServ
        : IServicioBase<clsCategoriaDom, int>
    {
        private readonly IRepositorioBase<clsCategoriaDom, int> repo;
        private Excepcion excepcion = new Excepcion();

        public clsCategoriaServ(IRepositorioBase<clsCategoriaDom, int> _repo) 
        {
            repo = _repo;
        }

        public void Actualizar(clsCategoriaDom entidad)
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

        public clsCategoriaDom Insertar(clsCategoriaDom entidad)
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

        public clsCategoriaDom ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsCategoriaDom> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }
    }
}
