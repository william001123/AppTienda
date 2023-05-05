
using Datos.Entidades;
using Dominio.Modelos;

namespace Datos.Mappers
{
    public static class clsMovimientoMapper
    {
        public static Movimiento Map(this clsMovimientoDom model)
        {
            return new Movimiento()
            {
                IdMovimiento = model.IdMovimiento,
                IdOrigen = model.IdOrigen,
                IdTipoMovimiento = model.IdTipoMovimiento,
                IdTipoOrigen = model.IdTipoOrigen,
                UserId = model.UserId
            };
        }

        public static List<Movimiento> Map(this List<clsMovimientoDom> model)
        {
            List<Movimiento> Dtos = new List<Movimiento>();

            foreach (clsMovimientoDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static List<clsMovimientoDom> Map(this List<Movimiento> model)
        {
            List<clsMovimientoDom> Dtos = new List<clsMovimientoDom>();

            foreach (Movimiento modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsMovimientoDom Map(this Movimiento DTO)
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