using AppFinanciero.Infraestructura.Datos.Contextos;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using Datos.Mappers;

namespace Datos.Repositorio
{
    public class clsTipoUnidadRepo : IRepositorioBase<clsTipoUnidadDom, int>
    {
        private TiendaContexto db;

        public clsTipoUnidadRepo(TiendaContexto _db)
        {
            db = _db;
        }

        public void Actualizar(clsTipoUnidadDom entidad)
        {
            var Selecc = db.TipoUnidad.Where(olinea => olinea.IdTipoUnidad == entidad.IdTipoUnidad).FirstOrDefault();

            if (Selecc != null)
            {
                Selecc.strTipoUnidad = entidad.strTipoUnidad;

                db.Entry(Selecc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(int entidadID)
        {
            var Selecc = db.TipoUnidad.Where(olinea => olinea.IdTipoUnidad == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                db.TipoUnidad.Remove(Selecc);
            }
        }

        public clsTipoUnidadDom Insertar(clsTipoUnidadDom entidad)
        {
            db.TipoUnidad.Add(entidad.Map());
            return entidad;
        }

        public clsTipoUnidadDom ObtenerPorID(int entidadID)
        {
            var Selecc = db.TipoUnidad.Where(olinea => olinea.IdTipoUnidad == entidadID).FirstOrDefault();

            return Selecc.Map();
        }

        public List<clsTipoUnidadDom> ObtenerTodo()
        {
            return db.TipoUnidad.ToList().Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
