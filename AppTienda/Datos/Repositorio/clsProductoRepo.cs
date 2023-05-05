using AppFinanciero.Infraestructura.Datos.Contextos;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using Datos.Mappers;

namespace Datos.Repositorio
{
    public class clsProductoRepo : IRepositorioProducto<clsProductoDom, int, double>
    {
        private TiendaContexto db;

        public clsProductoRepo(TiendaContexto _db)
        {
            db = _db;
        }

        public void Actualizar(clsProductoDom entidad)
        {
            var Selecc = db.Producto.Where(olinea => olinea.IdProducto == entidad.IdProducto).FirstOrDefault();

            if (Selecc != null)
            {
                Selecc.strNombre = entidad.strNombre;
                Selecc.numPrecio = entidad.numPrecio;                

                db.Entry(Selecc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void ActualizarCant(int entidadID, double entidadCantidad)
        {
            var Selecc = db.Producto.Where(olinea => olinea.IdProducto == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                Selecc.numCantidad = entidadCantidad;               

                db.Entry(Selecc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(int entidadID)
        {
            var Selecc = db.Producto.Where(olinea => olinea.IdProducto == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                db.Producto.Remove(Selecc);
            }
        }

        public clsProductoDom Insertar(clsProductoDom entidad)
        {
            db.Producto.Add(entidad.Map());
            return entidad;
        }

        public clsProductoDom ObtenerPorID(int entidadID)
        {
            var Selecc = db.Producto.Where(olinea => olinea.IdProducto == entidadID).FirstOrDefault();

            return Selecc.Map();
        }

        public List<clsProductoDom> ObtenerTodo()
        {
            return db.Producto.ToList().Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
