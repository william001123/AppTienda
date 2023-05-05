using Aplicacion.Interfaces;
using Aplicacion.Maestras;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using static Aplicacion.Maestras.MensajesBase;

namespace Aplicacion.Servicios
{
    public class clsOrdenServ
        : IServicioActuaEstado<clsOrdenDom, int, string>
    {
        private readonly IRepositorioActuaEstado<clsOrdenDom, int, string> repo;
        private Excepcion excepcion = new Excepcion();

        public clsOrdenServ(IRepositorioActuaEstado<clsOrdenDom, int, string> _repo) 
        {
            repo = _repo;
        }

        public void ActualizarEstado(int entidadID, string entidadEstado)
        {
            try
            {
                repo.ActualizarEstado(entidadID, entidadEstado);
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

        public clsOrdenDom Insertar(clsOrdenDom entidad)
        {
            try
            {

                string strOrden;
                clsOrdenDom ultimo = new clsOrdenDom();
                string fmt = "0000.##";

                ultimo = ObtenerUltimo();

                if (ultimo.IdOrden != 0)
                {

                     strOrden = ultimo.strOrden.Substring(2, 4);
                }
                else
                {
                    strOrden = "0000";
                }               

                strOrden = "OR" + (Convert.ToInt32(strOrden) + 1).ToString(fmt);

                entidad.strOrden = strOrden;

                var result = repo.Insertar(entidad);
                repo.SalvarTodo();
                return result;
            }
            catch (Exception ex)
            {
                throw excepcion.Error(ex, Error.Insertar.GetEnumDescription());
            }
        }

        public clsOrdenDom ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsOrdenDom> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }

        public clsOrdenDom ObtenerUltimo()
        {
            return repo.ObtenerUltimo();
        }
    }
}
