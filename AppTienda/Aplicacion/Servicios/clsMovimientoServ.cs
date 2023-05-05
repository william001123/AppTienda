using Aplicacion.Interfaces;
using Aplicacion.Maestras;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using static Aplicacion.Maestras.MensajesBase;

namespace Aplicacion.Servicios
{
    public class clsMovimientoServ
        : IServicioInserList<clsMovimientoDom, int>
    {
        private readonly IRepositorioInserList<clsMovimientoDom, int> repo;
        private Excepcion excepcion = new Excepcion();

        public clsMovimientoServ(IRepositorioInserList<clsMovimientoDom, int> _repo) 
        {
            repo = _repo;
        }

        public clsMovimientoDom Insertar(clsMovimientoDom entidad)
        {
            try
            {
                repo.Insertar(entidad);
                repo.SalvarTodo();

                var result = ObtenerUltimo();

                return result;
            }
            catch (Exception ex)
            {
                throw excepcion.Error(ex, Error.Insertar.GetEnumDescription());
            }
        }

        public clsMovimientoDom ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsMovimientoDom> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }

        public clsMovimientoDom ObtenerUltimo()
        {
            return repo.ObtenerUltimo();
        }
    }
}
