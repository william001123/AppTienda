
using Datos.Entidades;
using Dominio.Modelos;

namespace Datos.Mappers
{
    public static class clsVentaDetalleMapper
    {
        public static VentaDetalle Map(this clsVentaDetalleDom model)
        {
            return new VentaDetalle()
            {
                IdVentaDetalle = model.IdVentaDetalle,
                IdVenta = model.IdVenta,
                IdProducto = model.IdProducto,
                numCantidad = model.numCantidad,
                numPrecio = model.numPrecio
            };
        }

        public static List<VentaDetalle> Map(this List<clsVentaDetalleDom> model)
        {
            List<VentaDetalle> Dtos = new List<VentaDetalle>();

            foreach (clsVentaDetalleDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static List<clsVentaDetalleDom> Map(this List<VentaDetalle> model)
        {
            List<clsVentaDetalleDom> Dtos = new List<clsVentaDetalleDom>();

            foreach (VentaDetalle modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsVentaDetalleDom Map(this VentaDetalle DTO)
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