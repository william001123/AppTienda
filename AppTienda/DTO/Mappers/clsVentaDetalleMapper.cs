
using Dominio.Modelos;
using DTO.DTOs;
using System.Reflection;

namespace DTO.Mappers
{
    public static class clsVentaDetalleMapper
    {
        public static clsVentaDetalleDTO Map(this clsVentaDetalleDom model)
        {
            return new clsVentaDetalleDTO()
            {
                IdVentaDetalle = model.IdVentaDetalle,
                IdVenta = model.IdVenta,
                IdProducto = model.IdProducto,
                numCantidad = model.numCantidad,
                numPrecio = model.numPrecio
            };
        }

        public static List<clsVentaDetalleDTO> Map(this List<clsVentaDetalleDom> model)
        {
            List<clsVentaDetalleDTO> Dtos = new List<clsVentaDetalleDTO>();

            foreach (clsVentaDetalleDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsVentaDetalleDom Map(this clsVentaDetalleDTO DTO)
        {
            return new clsVentaDetalleDom()
            {
                IdVentaDetalle = DTO.IdVentaDetalle,
                IdVenta = DTO.IdVenta,
                IdProducto = DTO.IdProducto,
                numCantidad = DTO.numCantidad,
                numPrecio = DTO.numPrecio
            };
        }

    }
}