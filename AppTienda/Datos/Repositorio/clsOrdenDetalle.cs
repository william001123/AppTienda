using AppFinanciero.Infraestructura.Datos.Contextos;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using Datos.Mappers;

namespace Datos.Repositorio
{
    public class clsOrdenDetalleRepo : IRepositorioObteIDEnc<clsOrdenDetalleDom, int, List<clsOrdenDetalleDom>>
    {
        private TiendaContexto db;

        public clsOrdenDetalleRepo(TiendaContexto _db)
        {
            db = _db;
        }

        public void Actualizar(clsOrdenDetalleDom entidad)
        {
            var Selecc = db.OrdenDetalle.Where(olinea => olinea.IdOrdenDetalle == entidad.IdOrdenDetalle).FirstOrDefault();

            if (Selecc != null)
            {
                Selecc.numCantidad = entidad.numCantidad;
                Selecc.numPrecio = entidad.numPrecio;

                db.Entry(Selecc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(int entidadID)
        {
            var Selecc = db.OrdenDetalle.Where(olinea => olinea.IdOrdenDetalle == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                db.OrdenDetalle.Remove(Selecc);
            }
        }

        public clsOrdenDetalleDom Insertar(clsOrdenDetalleDom entidad)
        {
            db.OrdenDetalle.Add(entidad.Map());
            return entidad;
        }

        public clsOrdenDetalleDom ObtenerPorID(int entidadID)
        {
            var Selecc = db.OrdenDetalle.Where(olinea => olinea.IdOrdenDetalle == entidadID).FirstOrDefault();

            if (Selecc == null)
                return new clsOrdenDetalleDom();
            else
                return Selecc.Map();
        }

        public List<clsOrdenDetalleDom> ObtenerPorIDEnc(int entidadID)
        {
            var Selecc = db.OrdenDetalle.Where(olinea => olinea.IdOrden == entidadID).ToList();

            if (Selecc == null)
                return new List<clsOrdenDetalleDom>();
            else
                return Selecc.Map();
        }

        public List<clsOrdenDetalleDom> ObtenerTodo()
        {
            return db.OrdenDetalle.ToList().Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
