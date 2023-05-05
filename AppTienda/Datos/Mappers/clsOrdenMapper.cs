using Datos.Entidades;
using Dominio.Modelos;

namespace Datos.Mappers
{
    public static class clsOrdenMapper
    {
        public static Orden Map(this clsOrdenDom model)
        {
            return new Orden()
            {
                IdOrden = model.IdOrden,
                IdProveedor = model.IdProveedor,
                strOrden = model.strOrden,
                dtFechaEntrega = model.dtFechaEntrega,
                dtFechaOrden = model.dtFechaOrden,
                numTotal = model.numTotal,
                UserId = model.UserId,
                strEstado = model.strEstado
            };
        }

        public static List<Orden> Map(this List<clsOrdenDom> model)
        {
            List<Orden> Dtos = new List<Orden>();

            foreach (clsOrdenDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static List<clsOrdenDom> Map(this List<Orden> model)
        {
            List<clsOrdenDom> Dtos = new List<clsOrdenDom>();

            foreach (Orden modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsOrdenDom Map(this Orden DTO)
        {
            return new clsOrdenDom()
            {
                IdOrden = DTO.IdOrden,
                IdProveedor = DTO.IdProveedor,
                strOrden = DTO.strOrden,
                dtFechaEntrega = DTO.dtFechaEntrega,
                dtFechaOrden = DTO.dtFechaOrden,
                numTotal = DTO.numTotal,
                UserId = DTO.UserId,
                strEstado = DTO.strEstado
            };
        }

    }
}