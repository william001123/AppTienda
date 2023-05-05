
using Dominio.Modelos;
using DTO.DTOs;
using System.Reflection;

namespace DTO.Mappers
{
    public static class clsTipoUnidadMapper
    {
        public static clsTipoUnidadDTO Map(this clsTipoUnidadDom model)
        {
            return new clsTipoUnidadDTO()
            {
                IdTipoUnidad = model.IdTipoUnidad,
                strTipoUnidad  = model.strTipoUnidad
            };
        }

        public static List<clsTipoUnidadDTO> Map(this List<clsTipoUnidadDom> model)
        {
            List<clsTipoUnidadDTO> Dtos = new List<clsTipoUnidadDTO>();

            foreach (clsTipoUnidadDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsTipoUnidadDom Map(this clsTipoUnidadDTO DTO)
        {
            return new clsTipoUnidadDom()
            {
                IdTipoUnidad = DTO.IdTipoUnidad,
                strTipoUnidad = DTO.strTipoUnidad
            };
        }

    }
}