using AppFinanciero.Infraestructura.Datos.Contextos;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using Datos.Mappers;
using Datos.Entidades;

namespace Datos.Repositorio
{
    public class clsRecepcionRepo : IRepositorioActuaEstado<clsRecepcionDom, int, string>
    {
        private TiendaContexto db;

        public clsRecepcionRepo(TiendaContexto _db)
        {
            db = _db;
        }

        public void ActualizarEstado(int entidadID, string entidadEstado)
        {
            var Selecc = db.Recepcion.Where(olinea => olinea.IdRecepcion == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                Selecc.strEstado = entidadEstado;

                db.Entry(Selecc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(int entidadID)
        {
            var Selecc = db.Recepcion.Where(olinea => olinea.IdRecepcion == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                db.Recepcion.Remove(Selecc);
            }
        }

        public clsRecepcionDom Insertar(clsRecepcionDom entidad)
        {
            db.Recepcion.Add(entidad.Map());
            return entidad;
        }

        public clsRecepcionDom ObtenerPorID(int entidadID)
        {
            var Selecc = db.Recepcion.Where(olinea => olinea.IdRecepcion == entidadID).FirstOrDefault();

            return Selecc.Map();
        }

        public List<clsRecepcionDom> ObtenerTodo()
        {
            return db.Recepcion.ToList().Map();
        }

        public clsRecepcionDom ObtenerUltimo()
        {
            var varlor = db.Recepcion.OrderByDescending(x => x.IdRecepcion).FirstOrDefault();
            if (varlor is null)
            {
                varlor = new Recepcion();
            }
            return varlor.Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
