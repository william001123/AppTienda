
using Dominio.Modelos;
using DTO.DTOs;
using System.Reflection;

namespace DTO.Mappers
{
    public static class clsOrdenDetalleMapper
    {
        public static clsOrdenDetalleDTO Map(this clsOrdenDetalleDom model)
        {
            return new clsOrdenDetalleDTO()
            {
                IdOrden = model.IdOrden,
                IdOrdenDetalle = model.IdOrdenDetalle,
                IdProducto = model.IdProducto,
                numCantidad = model.numCantidad,
                numPrecio = model.numPrecio
            };
        }

        public static List<clsOrdenDetalleDTO> Map(this List<clsOrdenDetalleDom> model)
        {
            List<clsOrdenDetalleDTO> Dtos = new List<clsOrdenDetalleDTO>();

            foreach (clsOrdenDetalleDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsOrdenDetalleDom Map(this clsOrdenDetalleDTO DTO)
        {
            return new clsOrdenDetalleDom()
            {
                IdOrden = DTO.IdOrden,
                IdOrdenDetalle = DTO.IdOrdenDetalle,
                IdProducto = DTO.IdProducto,
                numCantidad = DTO.numCantidad,
                numPrecio = DTO.numPrecio
            };
        }

    }
}