namespace Dominio.Interfaces.Repositorio
{
    public interface IRepositorioMoviDetalle<TEntidad, TEntidadID, TEntidadTip>
        : IInsertar<TEntidad>, IListar<TEntidad, TEntidadID>, ISalvarTodo
    {        
        TEntidadTip ObtenerPorIDEnc(TEntidadID entidadID);
    }
}
