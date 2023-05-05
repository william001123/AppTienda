using Datos.Entidades;
using Dominio.Modelos;

namespace Datos.Mappers
{
    public static class clsRecepcionDetalleMapper
    {
        public static RecepcionDetalle Map(this clsRecepcionDetalleDom model)
        {
            return new RecepcionDetalle()
            {
                IdRecepcionDetalle = model.IdRecepcionDetalle,
                IdProducto = model.IdProducto,
                IdRecepcion = model.IdRecepcion,
                numCantidad = model.numCantidad,
                numPrecio = model.numPrecio
            };
        }

        public static List<RecepcionDetalle> Map(this List<clsRecepcionDetalleDom> model)
        {
            List<RecepcionDetalle> Dtos = new List<RecepcionDetalle>();

            foreach (clsRecepcionDetalleDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static List<clsRecepcionDetalleDom> Map(this List<RecepcionDetalle> model)
        {
            List<clsRecepcionDetalleDom> Dtos = new List<clsRecepcionDetalleDom>();

            foreach (RecepcionDetalle modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsRecepcionDetalleDom Map(this RecepcionDetalle DTO)
        {
            return new clsRecepcionDetalleDom()
            {
                IdRecepcionDetalle = DTO.IdRecepcionDetalle,
                IdProducto = DTO.IdProducto,
                IdRecepcion = DTO.IdRecepcion,
                numCantidad = DTO.numCantidad,
                numPrecio = DTO.numPrecio
            };
        }

    }
}