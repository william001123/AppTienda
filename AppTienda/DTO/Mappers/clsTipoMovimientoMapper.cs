
using Dominio.Modelos;
using DTO.DTOs;
using System.Reflection;

namespace DTO.Mappers
{
    public static class clsTipoMovimientoMapper
    {
        public static clsTipoMovimientoDTO Map(this clsTipoMovimientoDom model)
        {
            return new clsTipoMovimientoDTO()
            {
                IdTipoMovimiento = model.IdTipoMovimiento,
                strTipoMovimiento = model.strTipoMovimiento
            };
        }

        public static List<clsTipoMovimientoDTO> Map(this List<clsTipoMovimientoDom> model)
        {
            List<clsTipoMovimientoDTO> Dtos = new List<clsTipoMovimientoDTO>();

            foreach (clsTipoMovimientoDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsTipoMovimientoDom Map(this clsTipoMovimientoDTO DTO)
        {
            return new clsTipoMovimientoDom()
            {
                IdTipoMovimiento = DTO.IdTipoMovimiento,
                strTipoMovimiento = DTO.strTipoMovimiento
            };
        }

    }
}