using AppFinanciero.Infraestructura.Datos.Contextos;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using Datos.Mappers;

namespace Datos.Repositorio
{
    public class clsEmpleadoRepo : IRepositorioBase<clsEmpleadoDom, int>
    {
        private TiendaContexto db;

        public clsEmpleadoRepo(TiendaContexto _db)
        {
            db = _db;
        }

        public void Actualizar(clsEmpleadoDom entidad)
        {
            var Selecc = db.Empleado.Where(olinea => olinea.IdEmpleado == entidad.IdEmpleado).FirstOrDefault();

            if (Selecc != null)
            {
                Selecc.strDocumento = entidad.strDocumento;
                Selecc.strNombre = entidad.strNombre;                

                db.Entry(Selecc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(int entidadID)
        {
            var Selecc = db.Empleado.Where(olinea => olinea.IdEmpleado == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                db.Empleado.Remove(Selecc);
            }
        }

        public clsEmpleadoDom Insertar(clsEmpleadoDom entidad)
        {
            db.Empleado.Add(entidad.Map());
            return entidad;
        }

        public clsEmpleadoDom ObtenerPorID(int entidadID)
        {
            var Selecc = db.Empleado.Where(olinea => olinea.IdEmpleado == entidadID).FirstOrDefault();

            return Selecc.Map();
        }

        public List<clsEmpleadoDom> ObtenerTodo()
        {
            return db.Empleado.ToList().Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
