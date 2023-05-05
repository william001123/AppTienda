using Aplicacion.Interfaces;
using Aplicacion.Maestras;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using static Aplicacion.Maestras.MensajesBase;

namespace Aplicacion.Servicios
{
    public class clsProductoServ
        : IServicioProducto<clsProductoDom, int, double>
    {
        private readonly IRepositorioProducto<clsProductoDom, int, double> repo;
        private Excepcion excepcion = new Excepcion();

        public clsProductoServ(IRepositorioProducto<clsProductoDom, int, double> _repo) 
        {
            repo = _repo;
        }

        public void Actualizar(clsProductoDom entidad)
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

        public void ActualizarCant(int entidadID, double entidadCantidad)
        {
            try
            {
                repo.ActualizarCant(entidadID, entidadCantidad);
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

        public clsProductoDom Insertar(clsProductoDom entidad)
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

        public clsProductoDom ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsProductoDom> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }
    }
}
