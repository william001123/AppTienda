
using Dominio.Modelos;
using DTO.DTOs;
using System.Reflection;

namespace DTO.Mappers
{
    public static class clsCategoriaMapper
    {
        public static clsCategoriaDTO Map(this clsCategoriaDom model)
        {
            return new clsCategoriaDTO()
            {
                IdCategoria = model.IdCategoria,
                strCategoria = model.strCategoria
            };
        }

        public static List<clsCategoriaDTO> Map(this List<clsCategoriaDom> model)
        {
            List<clsCategoriaDTO> Dtos = new List<clsCategoriaDTO>();

            foreach (clsCategoriaDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsCategoriaDom Map(this clsCategoriaDTO DTO)
        {
            return new clsCategoriaDom()
            {
                IdCategoria = DTO.IdCategoria,
                strCategoria = DTO.strCategoria
            };
        }

    }
}