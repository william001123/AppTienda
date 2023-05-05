using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorio
{
    public interface IRepositorioInserList<TEntidad, TEntidadID>
        : IInsertar<TEntidad>, IListar<TEntidad, TEntidadID>, ISalvarTodo
    {
        TEntidad ObtenerUltimo();
    }
}
