using AppFinanciero.Infraestructura.Datos.Contextos;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using Datos.Mappers;
using Datos.Entidades;

namespace Datos.Repositorio
{
    public class clsOrdenRepo : IRepositorioActuaEstado<clsOrdenDom, int, string>
    {
        private TiendaContexto db;

        public clsOrdenRepo(TiendaContexto _db)
        {
            db = _db;
        }

        public void ActualizarEstado(int entidadID, string entidadEstado)
        {
            var Selecc = db.Orden.Where(olinea => olinea.IdOrden == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                Selecc.strEstado = entidadEstado;

                db.Entry(Selecc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(int entidadID)
        {
            var Selecc = db.Orden.Where(olinea => olinea.IdOrden == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                db.Orden.Remove(Selecc);
            }
        }

        public clsOrdenDom Insertar(clsOrdenDom entidad)
        {
            db.Orden.Add(entidad.Map());
            return entidad;
        }

        public clsOrdenDom ObtenerPorID(int entidadID)
        {
            var Selecc = db.Orden.Where(olinea => olinea.IdOrden == entidadID).FirstOrDefault();

            return Selecc.Map();
        }

        public List<clsOrdenDom> ObtenerTodo()
        {
            return db.Orden.ToList().Map();
        }

        public clsOrdenDom ObtenerUltimo()
        {
            var varlor = db.Orden.OrderByDescending(x => x.IdOrden).FirstOrDefault();
            if (varlor is null)
            {
                varlor = new Orden();
            }
            return varlor.Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
