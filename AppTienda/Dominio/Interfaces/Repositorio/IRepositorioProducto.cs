using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorio
{
    public interface IRepositorioProducto<TEntidad, TEntidadID, TEntidadID2>
        : IInsertar<TEntidad>, IActualizar<TEntidad>, IEliminar<TEntidadID>, IListar<TEntidad, TEntidadID>, ISalvarTodo
    {
        void ActualizarCant(TEntidadID entidadID, TEntidadID2 entidadCantidad);
    }
}
