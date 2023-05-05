
using Datos.Entidades;
using Dominio.Modelos;

namespace Datos.Mappers
{
    public static class clsCategoriaMapper
    {
        public static Categoria Map(this clsCategoriaDom model)
        {
            return new Categoria()
            {
                IdCategoria = model.IdCategoria,
                strCategoria = model.strCategoria
            };
        }

        public static List<Categoria> Map(this List<clsCategoriaDom> model)
        {
            List<Categoria> Dtos = new List<Categoria>();

            foreach (clsCategoriaDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static List<clsCategoriaDom> Map(this List<Categoria> model)
        {
            List<clsCategoriaDom> Dtos = new List<clsCategoriaDom>();

            foreach (Categoria modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsCategoriaDom Map(this Categoria DTO)
        {
            return new clsCategoriaDom()
            {
                IdCategoria = DTO.IdCategoria,
                strCategoria = DTO.strCategoria
            };
        }

    }
}