
using Datos.Entidades;
using Dominio.Modelos;

namespace Datos.Mappers
{
    public static class clsTipoOrigenMapper
    {
        public static TipoOrigen Map(this clsTipoOrigenDom model)
        {
            return new TipoOrigen()
            {
                IdTipoOrigen = model.IdTipoOrigen,
                strTipoOrigen = model.strTipoOrigen
            };
        }

        public static List<TipoOrigen> Map(this List<clsTipoOrigenDom> model)
        {
            List<TipoOrigen> Dtos = new List<TipoOrigen>();

            foreach (clsTipoOrigenDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static List<clsTipoOrigenDom> Map(this List<TipoOrigen> model)
        {
            List<clsTipoOrigenDom> Dtos = new List<clsTipoOrigenDom>();

            foreach (TipoOrigen modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsTipoOrigenDom Map(this TipoOrigen DTO)
        {
            return new clsTipoOrigenDom()
            {
                IdTipoOrigen = DTO.IdTipoOrigen,
                strTipoOrigen = DTO.strTipoOrigen
            };
        }

    }
}