using AppFinanciero.Infraestructura.Datos.Contextos;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using Datos.Mappers;

namespace Datos.Repositorio
{
    public class clsVentaDetalleRepo : IRepositorioObteIDEnc<clsVentaDetalleDom, int, List<clsVentaDetalleDom>>
    {
        private TiendaContexto db;

        public clsVentaDetalleRepo(TiendaContexto _db)
        {
            db = _db;
        }

        public void Actualizar(clsVentaDetalleDom entidad)
        {
            var Selecc = db.VentaDetalle.Where(olinea => olinea.IdVentaDetalle == entidad.IdVentaDetalle).FirstOrDefault();

            if (Selecc != null)
            {
                Selecc.numCantidad = entidad.numCantidad;
                Selecc.numPrecio = entidad.numPrecio;

                db.Entry(Selecc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(int entidadID)
        {
            var Selecc = db.VentaDetalle.Where(olinea => olinea.IdVentaDetalle == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                db.VentaDetalle.Remove(Selecc);
            }
        }

        public clsVentaDetalleDom Insertar(clsVentaDetalleDom entidad)
        {
            db.VentaDetalle.Add(entidad.Map());
            return entidad;
        }

        public clsVentaDetalleDom ObtenerPorID(int entidadID)
        {
            var Selecc = db.VentaDetalle.Where(olinea => olinea.IdVentaDetalle == entidadID).FirstOrDefault();

            if (Selecc == null)
                return new clsVentaDetalleDom();
            else
                return Selecc.Map();
        }

        public List<clsVentaDetalleDom> ObtenerPorIDEnc(int entidadID)
        {
            var Selecc = db.VentaDetalle.Where(olinea => olinea.IdVenta == entidadID).ToList();

            if (Selecc == null)
                return new List<clsVentaDetalleDom>();
            else
                return Selecc.Map();
        }

        public List<clsVentaDetalleDom> ObtenerTodo()
        {
            return db.VentaDetalle.ToList().Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
