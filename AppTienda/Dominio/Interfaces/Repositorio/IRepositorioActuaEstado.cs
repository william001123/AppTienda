using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorio
{
    public interface IRepositorioActuaEstado<TEntidad, TEntidadID, TEntidadID2>
        : IRepositorioInserList<TEntidad, TEntidadID>, IEliminar<TEntidadID>, ISalvarTodo
    {
        TEntidad ObtenerUltimo();
        void ActualizarEstado(TEntidadID entidadID, TEntidadID2 entidadEstado);
    }
}
