using Dominio.Interfaces;

namespace Aplicacion.Interfaces
{
    public interface IServicioObteIDEnc<TEntidad, TEntidadID, TEntidadTip>
        : IInsertar<TEntidad>, IActualizar<TEntidad>, IEliminar<TEntidadID>, IListar<TEntidad, TEntidadID>
    {
        TEntidadTip ObtenerPorIDEnc(TEntidadID entidadID);
    }
}
