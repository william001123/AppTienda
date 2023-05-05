
using Datos.Entidades;
using Dominio.Modelos;

namespace Datos.Mappers
{
    public static class clsProductoMapper
    {
        public static Producto Map(this clsProductoDom model)
        {
            return new Producto()
            {
                IdProducto = model.IdProducto,
                IdCategoria = model.IdCategoria,
                IdTipoUnidad = model.IdTipoUnidad,
                numCantidad = model.numCantidad,
                strNombre = model.strNombre,
                bnReferencia = model.bnReferencia,
                numPrecio = model.numPrecio
            };
        }

        public static List<Producto> Map(this List<clsProductoDom> model)
        {
            List<Producto> Dtos = new List<Producto>();

            foreach (clsProductoDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static List<clsProductoDom> Map(this List<Producto> model)
        {
            List<clsProductoDom> Dtos = new List<clsProductoDom>();

            foreach (Producto modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsProductoDom Map(this Producto DTO)
        {
            return new clsProductoDom()
            {
                IdProducto = DTO.IdProducto,
                IdCategoria = DTO.IdCategoria,
                IdTipoUnidad = DTO.IdTipoUnidad,
                numCantidad = DTO.numCantidad,
                strNombre = DTO.strNombre,
                bnReferencia = DTO.bnReferencia,
                numPrecio = DTO.numPrecio
            };
        }

    }
}