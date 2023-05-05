
using Datos.Entidades;
using Dominio.Modelos;

namespace Datos.Mappers
{
    public static class clsTipoMovimientoMapper
    {
        public static TipoMovimiento Map(this clsTipoMovimientoDom model)
        {
            return new TipoMovimiento()
            {
                IdTipoMovimiento = model.IdTipoMovimiento,
                strTipoMovimiento = model.strTipoMovimiento
            };
        }

        public static List<TipoMovimiento> Map(this List<clsTipoMovimientoDom> model)
        {
            List<TipoMovimiento> Dtos = new List<TipoMovimiento>();

            foreach (clsTipoMovimientoDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static List<clsTipoMovimientoDom> Map(this List<TipoMovimiento> model)
        {
            List<clsTipoMovimientoDom> Dtos = new List<clsTipoMovimientoDom>();

            foreach (TipoMovimiento modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsTipoMovimientoDom Map(this TipoMovimiento DTO)
        {
            return new clsTipoMovimientoDom()
            {
                IdTipoMovimiento = DTO.IdTipoMovimiento,
                strTipoMovimiento = DTO.strTipoMovimiento
            };
        }

    }
}