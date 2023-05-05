using AppFinanciero.Infraestructura.Datos.Contextos;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using Datos.Mappers;

namespace Datos.Repositorio
{
    public class clsRecepcionDetalleRepo : IRepositorioObteIDEnc<clsRecepcionDetalleDom, int, List<clsRecepcionDetalleDom>>
    {
        private TiendaContexto db;

        public clsRecepcionDetalleRepo(TiendaContexto _db)
        {
            db = _db;
        }

        public void Actualizar(clsRecepcionDetalleDom entidad)
        {
            var Selecc = db.RecepcionDetalle.Where(olinea => olinea.IdRecepcionDetalle == entidad.IdRecepcionDetalle).FirstOrDefault();

            if (Selecc != null)
            {
                Selecc.numCantidad = entidad.numCantidad;
                Selecc.numPrecio = entidad.numPrecio;

                db.Entry(Selecc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(int entidadID)
        {
            var Selecc = db.RecepcionDetalle.Where(olinea => olinea.IdRecepcionDetalle == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                db.RecepcionDetalle.Remove(Selecc);
            }
        }

        public clsRecepcionDetalleDom Insertar(clsRecepcionDetalleDom entidad)
        {
            db.RecepcionDetalle.Add(entidad.Map());
            return entidad;
        }

        public clsRecepcionDetalleDom ObtenerPorID(int entidadID)
        {
            var Selecc = db.RecepcionDetalle.Where(olinea => olinea.IdRecepcionDetalle == entidadID).FirstOrDefault();

            return Selecc.Map();
        }

        public List<clsRecepcionDetalleDom> ObtenerPorIDEnc(int entidadID)
        {
            var Selecc = db.RecepcionDetalle.Where(olinea => olinea.IdRecepcion == entidadID).ToList();

            if (Selecc == null)
                return new List<clsRecepcionDetalleDom>();
            else
                return Selecc.Map();
        }

        public List<clsRecepcionDetalleDom> ObtenerTodo()
        {
            return db.RecepcionDetalle.ToList().Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
