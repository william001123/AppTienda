using AppFinanciero.Infraestructura.Datos.Contextos;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using Datos.Mappers;
using Datos.Entidades;

namespace Datos.Repositorio
{
    public class clsMovimientoDetalleRepo : IRepositorioMoviDetalle<clsMovimientoDetalleDom, int, List<clsMovimientoDetalleDom>>
    {
        private TiendaContexto db;

        public clsMovimientoDetalleRepo(TiendaContexto _db)
        {
            db = _db;
        }

        public clsMovimientoDetalleDom Insertar(clsMovimientoDetalleDom entidad)
        {
            db.MovimientoDetalle.Add(entidad.Map());
            return entidad;
        }

        public clsMovimientoDetalleDom ObtenerPorID(int entidadID)
        {
            var Selecc = db.MovimientoDetalle.Where(olinea => olinea.IdMovimientoDetalle == entidadID).FirstOrDefault();

            if (Selecc == null)
                return new clsMovimientoDetalleDom();
            else
                return Selecc.Map();
        }

        public List<clsMovimientoDetalleDom> ObtenerPorIDEnc(int entidadID)
        {
            var Selecc = db.MovimientoDetalle.Where(olinea => olinea.IdMovimiento == entidadID).ToList();

            if (Selecc == null)
                return new List<clsMovimientoDetalleDom>();
            else
                return Selecc.Map();
        }

        public List<clsMovimientoDetalleDom> ObtenerTodo()
        {
            return db.MovimientoDetalle.ToList().Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
