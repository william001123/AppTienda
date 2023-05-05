using AppFinanciero.Infraestructura.Datos.Contextos;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using Datos.Mappers;

namespace Datos.Repositorio
{
    public class clsUsuarioRepo : IRepositorioObteIDEnc<clsUsuarioDom, int, clsUsuarioDom>
    {
        private TiendaContexto db;

        public clsUsuarioRepo(TiendaContexto _db)
        {
            db = _db;
        }

        public void Actualizar(clsUsuarioDom entidad)
        {
            var Selecc = db.Usuario.Where(olinea => olinea.UserId == entidad.UserId).FirstOrDefault();

            if (Selecc != null)
            {
                Selecc.strContraseña = entidad.strContraseña;

                db.Entry(Selecc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(int entidadID)
        {
            var Selecc = db.Usuario.Where(olinea => olinea.UserId == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                db.Usuario.Remove(Selecc);
            }
        }

        public clsUsuarioDom Insertar(clsUsuarioDom entidad)
        {
            db.Usuario.Add(entidad.Map());
            return entidad;
        }

        public clsUsuarioDom ObtenerPorID(int entidadID)
        {
            var Selecc = db.Usuario.Where(olinea => olinea.UserId == entidadID).FirstOrDefault();
            if (Selecc == null)
                return new clsUsuarioDom();
            else
                return Selecc.Map();
        }

        public clsUsuarioDom ObtenerPorIDEnc(int entidadID)
        {
            var Selecc = db.Usuario.Where(olinea => olinea.IdEmpleado == entidadID).FirstOrDefault();

            if (Selecc == null)
                return new clsUsuarioDom();
            else
                return Selecc.Map();
        }

        public List<clsUsuarioDom> ObtenerTodo()
        {
            return db.Usuario.ToList().Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
