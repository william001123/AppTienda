
using Dominio.Modelos;
using DTO.DTOs;
using System.Reflection;

namespace DTO.Mappers
{
    public static class clsTipoOrigenMapper
    {
        public static clsTipoOrigenDTO Map(this clsTipoOrigenDom model)
        {
            return new clsTipoOrigenDTO()
            {
                IdTipoOrigen = model.IdTipoOrigen,
                strTipoOrigen = model.strTipoOrigen
            };
        }

        public static List<clsTipoOrigenDTO> Map(this List<clsTipoOrigenDom> model)
        {
            List<clsTipoOrigenDTO> Dtos = new List<clsTipoOrigenDTO>();

            foreach (clsTipoOrigenDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsTipoOrigenDom Map(this clsTipoOrigenDTO DTO)
        {
            return new clsTipoOrigenDom()
            {
                IdTipoOrigen = DTO.IdTipoOrigen,
                strTipoOrigen = DTO.strTipoOrigen
            };
        }

    }
}