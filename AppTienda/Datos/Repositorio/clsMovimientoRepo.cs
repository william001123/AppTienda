using AppFinanciero.Infraestructura.Datos.Contextos;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using Datos.Mappers;
using Datos.Entidades;

namespace Datos.Repositorio
{
    public class clsMovimientoRepo : IRepositorioInserList<clsMovimientoDom, int>
    {
        private TiendaContexto db;

        public clsMovimientoRepo(TiendaContexto _db)
        {
            db = _db;
        }
        
        public clsMovimientoDom Insertar(clsMovimientoDom entidad)
        {
            db.Movimiento.Add(entidad.Map());
            return entidad;
        }

        public clsMovimientoDom ObtenerPorID(int entidadID)
        {
            var Selecc = db.Movimiento.Where(olinea => olinea.IdMovimiento == entidadID).FirstOrDefault();

            return Selecc.Map();
        }

        public List<clsMovimientoDom> ObtenerTodo()
        {
            return db.Movimiento.ToList().Map();
        }

        public clsMovimientoDom ObtenerUltimo()
        {
            var varlor = db.Movimiento.OrderByDescending(x => x.IdMovimiento).FirstOrDefault();
            if (varlor is null)
            {
                varlor = new Movimiento();
            }
            return varlor.Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
