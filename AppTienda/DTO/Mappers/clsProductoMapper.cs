
using Dominio.Modelos;
using DTO.DTOs;
using System.Reflection;

namespace DTO.Mappers
{
    public static class clsProductoMapper
    {
        public static clsProductoDTO Map(this clsProductoDom model)
        {
            return new clsProductoDTO()
            {
                IdProducto = model.IdProducto,
                IdCategoria = model.IdCategoria,
                IdTipoUnidad = model.IdTipoUnidad,
                strNombre = model.strNombre,
                bnReferencia = model.bnReferencia,
                numPrecio = model.numPrecio,
                numCantidad = model.numCantidad       
            };
        }

        public static List<clsProductoDTO> Map(this List<clsProductoDom> model)
        {
            List<clsProductoDTO> Dtos = new List<clsProductoDTO>();

            foreach (clsProductoDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsProductoDom Map(this clsProductoDTO DTO)
        {
            return new clsProductoDom()
            {
                IdProducto = DTO.IdProducto,
                IdCategoria = DTO.IdCategoria,
                IdTipoUnidad = DTO.IdTipoUnidad,
                strNombre = DTO.strNombre,
                bnReferencia = DTO.bnReferencia,
                numPrecio = DTO.numPrecio,
                numCantidad = DTO.numCantidad
            };
        }

    }
}