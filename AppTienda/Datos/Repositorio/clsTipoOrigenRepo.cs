using AppFinanciero.Infraestructura.Datos.Contextos;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using Datos.Mappers;

namespace Datos.Repositorio
{
    public class clsTipoOrigenRepo : IRepositorioBase<clsTipoOrigenDom, int>
    {
        private TiendaContexto db;

        public clsTipoOrigenRepo(TiendaContexto _db)
        {
            db = _db;
        }

        public void Actualizar(clsTipoOrigenDom entidad)
        {
            var Selecc = db.TipoOrigen.Where(olinea => olinea.IdTipoOrigen == entidad.IdTipoOrigen).FirstOrDefault();

            if (Selecc != null)
            {
                Selecc.strTipoOrigen = entidad.strTipoOrigen;

                db.Entry(Selecc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(int entidadID)
        {
            var Selecc = db.TipoOrigen.Where(olinea => olinea.IdTipoOrigen == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                db.TipoOrigen.Remove(Selecc);
            }
        }

        public clsTipoOrigenDom Insertar(clsTipoOrigenDom entidad)
        {
            db.TipoOrigen.Add(entidad.Map());
            return entidad;
        }

        public clsTipoOrigenDom ObtenerPorID(int entidadID)
        {
            var Selecc = db.TipoOrigen.Where(olinea => olinea.IdTipoOrigen == entidadID).FirstOrDefault();

            return Selecc.Map();
        }

        public List<clsTipoOrigenDom> ObtenerTodo()
        {
            return db.TipoOrigen.ToList().Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
