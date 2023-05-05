using Aplicacion.Interfaces;
using Aplicacion.Maestras;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using static Aplicacion.Maestras.MensajesBase;

namespace Aplicacion.Servicios
{
    public class clsVentaServ
        : IServicioActuaEstado<clsVentaDom, int, string>
    {
        private readonly IRepositorioActuaEstado<clsVentaDom, int, string> repo;
        private Excepcion excepcion = new Excepcion();

        public clsVentaServ(IRepositorioActuaEstado<clsVentaDom, int, string> _repo) 
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

        public clsVentaDom Insertar(clsVentaDom entidad)
        {
            try
            {

                string strVenta;
                clsVentaDom ultimo = new clsVentaDom();
                string fmt = "0000.##";

                ultimo = ObtenerUltimo();

                if (ultimo.IdVenta != 0)
                {

                    strVenta = ultimo.strVenta.Substring(2, 4);
                }
                else
                {
                    strVenta = "0000";
                }
                strVenta = "VN" + (Convert.ToInt32(strVenta) + 1).ToString(fmt);

                entidad.strVenta = strVenta;

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

        public clsVentaDom ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsVentaDom> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }

        public clsVentaDom ObtenerUltimo()
        {
            return repo.ObtenerUltimo();
        }
    }
}
