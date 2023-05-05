
using Datos.Entidades;
using Dominio.Modelos;

namespace Datos.Mappers
{
    public static class clsMovimientoDetalleMapper
    {
        public static MovimientoDetalle Map(this clsMovimientoDetalleDom model)
        {
            return new MovimientoDetalle()
            {
                IdProducto = model.IdProducto,
                IdMovimiento = model.IdMovimiento,
                IdMovimientoDetalle = model.IdMovimientoDetalle,
                numCantidad = model.numCantidad,
                numPrecio = model.numPrecio
            };
        }

        public static List<MovimientoDetalle> Map(this List<clsMovimientoDetalleDom> model)
        {
            List<MovimientoDetalle> Dtos = new List<MovimientoDetalle>();

            foreach (clsMovimientoDetalleDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static List<clsMovimientoDetalleDom> Map(this List<MovimientoDetalle> model)
        {
            List<clsMovimientoDetalleDom> Dtos = new List<clsMovimientoDetalleDom>();

            foreach (MovimientoDetalle modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsMovimientoDetalleDom Map(this MovimientoDetalle DTO)
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