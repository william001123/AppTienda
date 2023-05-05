using Dominio.Interfaces;

namespace Aplicacion.Interfaces
{
    public interface IServicioMoviDetalle<TEntidad, TEntidadID, TEntidadTip>
        : IListar<TEntidad, TEntidadID>
    {
        TEntidad Insertar(TEntidad entidad, TEntidadID TipoMovimiento);
        TEntidadTip ObtenerPorIDEnc(TEntidadID entidadID);
    }
}
