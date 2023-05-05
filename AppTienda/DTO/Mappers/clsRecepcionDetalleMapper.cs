using Dominio.Modelos;
using DTO.DTOs;
using System.Reflection;

namespace DTO.Mappers
{
    public static class clsRecepcionDetalleMapper
    {
        public static clsRecepcionDetalleDTO Map(this clsRecepcionDetalleDom model)
        {
            return new clsRecepcionDetalleDTO()
            {
                IdRecepcionDetalle = model.IdRecepcionDetalle,
                IdProducto = model.IdProducto,
                IdRecepcion = model.IdRecepcion,
                numCantidad = model.numCantidad,
                numPrecio = model.numPrecio
            };
        }

        public static List<clsRecepcionDetalleDTO> Map(this List<clsRecepcionDetalleDom> model)
        {
            List<clsRecepcionDetalleDTO> Dtos = new List<clsRecepcionDetalleDTO>();

            foreach (clsRecepcionDetalleDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsRecepcionDetalleDom Map(this clsRecepcionDetalleDTO DTO)
        {
            return new clsRecepcionDetalleDom()
            {
                IdRecepcionDetalle = DTO.IdRecepcionDetalle,
                IdProducto = DTO.IdProducto,
                IdRecepcion = DTO.IdRecepcion,
                numCantidad = DTO.numCantidad,
                numPrecio = DTO.numPrecio
            };
        }

    }
}