using Dominio.Interfaces;

namespace Aplicacion.Interfaces
{
    public interface IServicioInserList<TEntidad, TEntidadID>
        : IInsertar<TEntidad>, IListar<TEntidad, TEntidadID>
    {
        TEntidad ObtenerUltimo();
    }
}
