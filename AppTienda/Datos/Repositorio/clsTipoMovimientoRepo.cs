using AppFinanciero.Infraestructura.Datos.Contextos;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using Datos.Mappers;

namespace Datos.Repositorio
{
    public class clsTipoMovimientoRepo : IRepositorioBase<clsTipoMovimientoDom, int>
    {
        private TiendaContexto db;

        public clsTipoMovimientoRepo(TiendaContexto _db)
        {
            db = _db;
        }

        public void Actualizar(clsTipoMovimientoDom entidad)
        {
            var Selecc = db.TipoMovimiento.Where(olinea => olinea.IdTipoMovimiento == entidad.IdTipoMovimiento).FirstOrDefault();

            if (Selecc != null)
            {
                Selecc.strTipoMovimiento = entidad.strTipoMovimiento;

                db.Entry(Selecc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(int entidadID)
        {
            var Selecc = db.TipoMovimiento.Where(olinea => olinea.IdTipoMovimiento == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                db.TipoMovimiento.Remove(Selecc);
            }
        }

        public clsTipoMovimientoDom Insertar(clsTipoMovimientoDom entidad)
        {
            db.TipoMovimiento.Add(entidad.Map());
            return entidad;
        }

        public clsTipoMovimientoDom ObtenerPorID(int entidadID)
        {
            var Selecc = db.TipoMovimiento.Where(olinea => olinea.IdTipoMovimiento == entidadID).FirstOrDefault();

            return Selecc.Map();
        }

        public List<clsTipoMovimientoDom> ObtenerTodo()
        {
            return db.TipoMovimiento.ToList().Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
