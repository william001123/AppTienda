using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorio
{
    public interface IRepositorioObteIDEnc<TEntidad, TEntidadID, TEntidadTip>
        : IInsertar<TEntidad>, IActualizar<TEntidad>, IEliminar<TEntidadID>, IListar<TEntidad, TEntidadID>, ISalvarTodo
    {
        TEntidadTip ObtenerPorIDEnc(TEntidadID entidadID);
    }
}
