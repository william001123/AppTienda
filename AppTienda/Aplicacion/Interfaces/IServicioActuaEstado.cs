using Dominio.Interfaces;

namespace Aplicacion.Interfaces
{
    public interface IServicioActuaEstado<TEntidad, TEntidadID, TEntidadID2>
        : IServicioInserList<TEntidad, TEntidadID>, IEliminar<TEntidadID>
    {
        TEntidad ObtenerUltimo();
        void ActualizarEstado(TEntidadID entidadID, TEntidadID2 entidadEstado);
    }
}
