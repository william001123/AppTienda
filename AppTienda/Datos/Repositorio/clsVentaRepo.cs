using AppFinanciero.Infraestructura.Datos.Contextos;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using Datos.Mappers;
using Datos.Entidades;

namespace Datos.Repositorio
{
    public class clsVentaRepo : IRepositorioActuaEstado<clsVentaDom, int, string>
    {
        private TiendaContexto db;

        public clsVentaRepo(TiendaContexto _db)
        {
            db = _db;
        }

        public void ActualizarEstado(int entidadID, string entidadEstado)
        {
            var Selecc = db.Venta.Where(olinea => olinea.IdVenta == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                Selecc.strEstado = entidadEstado;

                db.Entry(Selecc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(int entidadID)
        {
            var Selecc = db.Venta.Where(olinea => olinea.IdVenta == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                db.Venta.Remove(Selecc);
            }
        }

        public clsVentaDom Insertar(clsVentaDom entidad)
        {
            db.Venta.Add(entidad.Map());
            return entidad;
        }

        public clsVentaDom ObtenerPorID(int entidadID)
        {
            var Selecc = db.Venta.Where(olinea => olinea.IdVenta == entidadID).FirstOrDefault();

            return Selecc.Map();
        }

        public List<clsVentaDom> ObtenerTodo()
        {
            return db.Venta.ToList().Map();
        }

        public clsVentaDom ObtenerUltimo()
        {
            var varlor = db.Venta.OrderByDescending(x => x.IdVenta).FirstOrDefault();
            if (varlor is null)
            {
                varlor = new Venta();
            }
            return varlor.Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
