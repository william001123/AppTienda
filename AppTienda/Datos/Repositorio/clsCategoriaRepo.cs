using AppFinanciero.Infraestructura.Datos.Contextos;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using Datos.Mappers;

namespace Datos.Repositorio
{
    public class clsCategoriaRepo : IRepositorioBase<clsCategoriaDom, int>
    {
        private TiendaContexto db;

        public clsCategoriaRepo(TiendaContexto _db)
        {
            db = _db;
        }

        public void Actualizar(clsCategoriaDom entidad)
        {
            var Selecc = db.Categoria.Where(olinea => olinea.IdCategoria == entidad.IdCategoria).FirstOrDefault();

            if (Selecc != null)
            {
                Selecc.strCategoria = entidad.strCategoria;                

                db.Entry(Selecc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(int entidadID)
        {
            var Selecc = db.Categoria.Where(olinea => olinea.IdCategoria == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                db.Categoria.Remove(Selecc);
            }
        }

        public clsCategoriaDom Insertar(clsCategoriaDom entidad)
        {
            db.Categoria.Add(entidad.Map());
            return entidad;
        }

        public clsCategoriaDom ObtenerPorID(int entidadID)
        {
            var Selecc = db.Categoria.Where(olinea => olinea.IdCategoria == entidadID).FirstOrDefault();

            return Selecc.Map();
        }

        public List<clsCategoriaDom> ObtenerTodo()
        {
            return db.Categoria.ToList().Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
