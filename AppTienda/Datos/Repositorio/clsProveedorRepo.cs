using AppFinanciero.Infraestructura.Datos.Contextos;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using Datos.Mappers;

namespace Datos.Repositorio
{
    public class clsProveedorRepo : IRepositorioBase<clsProveedorDom, int>
    {
        private TiendaContexto db;

        public clsProveedorRepo(TiendaContexto _db)
        {
            db = _db;
        }

        public void Actualizar(clsProveedorDom entidad)
        {
            var Selecc = db.Proveedor.Where(olinea => olinea.IdProveedor == entidad.IdProveedor).FirstOrDefault();

            if (Selecc != null)
            {
                Selecc.strNIT = entidad.strNIT;
                Selecc.strNombre = entidad.strNombre;
                Selecc.strTelefono = entidad.strTelefono;
                Selecc.strDireccion = entidad.strDireccion;

                db.Entry(Selecc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(int entidadID)
        {
            var Selecc = db.Proveedor.Where(olinea => olinea.IdProveedor == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                db.Proveedor.Remove(Selecc);
            }
        }

        public clsProveedorDom Insertar(clsProveedorDom entidad)
        {
            db.Proveedor.Add(entidad.Map());
            return entidad;
        }

        public clsProveedorDom ObtenerPorID(int entidadID)
        {
            var Selecc = db.Proveedor.Where(olinea => olinea.IdProveedor == entidadID).FirstOrDefault();

            return Selecc.Map();
        }

        public List<clsProveedorDom> ObtenerTodo()
        {
            return db.Proveedor.ToList().Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
