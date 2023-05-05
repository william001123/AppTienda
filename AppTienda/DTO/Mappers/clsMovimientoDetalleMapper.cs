
using Dominio.Modelos;
using DTO.DTOs;
using System.Reflection;

namespace DTO.Mappers
{
    public static class clsMovimientoDetalleMapper
    {
        public static clsMovimientoDetalleDTO Map(this clsMovimientoDetalleDom model)
        {
            return new clsMovimientoDetalleDTO()
            {
                IdProducto = model.IdProducto,
                IdMovimiento = model.IdMovimiento,
                IdMovimientoDetalle = model.IdMovimientoDetalle,
                numCantidad = model.numCantidad,
                numPrecio = model.numPrecio
            };
        }

        public static List<clsMovimientoDetalleDTO> Map(this List<clsMovimientoDetalleDom> model)
        {
            List<clsMovimientoDetalleDTO> Dtos = new List<clsMovimientoDetalleDTO>();

            foreach (clsMovimientoDetalleDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsMovimientoDetalleDom Map(this clsMovimientoDetalleDTO DTO)
        {
            return new clsMovimientoDetalleDom()
            {
                IdProducto = DTO.IdProducto,
                IdMovimiento = DTO.IdMovimiento,
                IdMovimientoDetalle = DTO.IdMovimientoDetalle,
                numCantidad = DTO.numCantidad,
                numPrecio = DTO.numPrecio
            };
        }

    }
}