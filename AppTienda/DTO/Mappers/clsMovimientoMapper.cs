
using Dominio.Modelos;
using DTO.DTOs;
using System.Reflection;

namespace DTO.Mappers
{
    public static class clsMovimientoMapper
    {
        public static clsMovimientoDTO Map(this clsMovimientoDom model)
        {
            return new clsMovimientoDTO()
            {
                IdMovimiento = model.IdMovimiento,
                IdOrigen = model.IdOrigen,
                IdTipoMovimiento = model.IdTipoMovimiento,
                IdTipoOrigen = model.IdTipoOrigen,
                UserId = model.UserId
            };
        }

        public static List<clsMovimientoDTO> Map(this List<clsMovimientoDom> model)
        {
            List<clsMovimientoDTO> Dtos = new List<clsMovimientoDTO>();

            foreach (clsMovimientoDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsMovimientoDom Map(this clsMovimientoDTO DTO)
        {
            return new clsMovimientoDom()
            {
                IdMovimiento = DTO.IdMovimiento,
                IdOrigen = DTO.IdOrigen,
                IdTipoMovimiento = DTO.IdTipoMovimiento,
                IdTipoOrigen = DTO.IdTipoOrigen,
                UserId = DTO.UserId
            };
        }

    }
}