
using Datos.Entidades;
using Dominio.Modelos;

namespace Datos.Mappers
{
    public static class clsOrdenDetalleMapper
    {
        public static OrdenDetalle Map(this clsOrdenDetalleDom model)
        {
            return new OrdenDetalle()
            {
                IdOrden = model.IdOrden,
                IdOrdenDetalle = model.IdOrdenDetalle,
                IdProducto = model.IdProducto,
                numCantidad = model.numCantidad,
                numPrecio = model.numPrecio
            };
        }

        public static List<OrdenDetalle> Map(this List<clsOrdenDetalleDom> model)
        {
            List<OrdenDetalle> Dtos = new List<OrdenDetalle>();

            foreach (clsOrdenDetalleDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static List<clsOrdenDetalleDom> Map(this List<OrdenDetalle> model)
        {
            List<clsOrdenDetalleDom> Dtos = new List<clsOrdenDetalleDom>();

            foreach (OrdenDetalle modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsOrdenDetalleDom Map(this OrdenDetalle DTO)
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