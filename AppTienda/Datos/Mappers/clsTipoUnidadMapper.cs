
using Datos.Entidades;
using Dominio.Modelos;

namespace Datos.Mappers
{
    public static class clsTipoUnidadMapper
    {
        public static TipoUnidad Map(this clsTipoUnidadDom model)
        {
            return new TipoUnidad()
            {
                IdTipoUnidad = model.IdTipoUnidad,
                strTipoUnidad  = model.strTipoUnidad
            };
        }

        public static List<TipoUnidad> Map(this List<clsTipoUnidadDom> model)
        {
            List<TipoUnidad> Dtos = new List<TipoUnidad>();

            foreach (clsTipoUnidadDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static List<clsTipoUnidadDom> Map(this List<TipoUnidad> model)
        {
            List<clsTipoUnidadDom> Dtos = new List<clsTipoUnidadDom>();

            foreach (TipoUnidad modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsTipoUnidadDom Map(this TipoUnidad DTO)
        {
            return new clsTipoUnidadDom()
            {
                IdTipoUnidad = DTO.IdTipoUnidad,
                strTipoUnidad = DTO.strTipoUnidad
            };
        }

    }
}