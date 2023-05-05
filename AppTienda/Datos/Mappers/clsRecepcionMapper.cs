using Datos.Entidades;
using Dominio.Modelos;

namespace Datos.Mappers
{
    public static class clsRecepcionMapper
    {
        public static Recepcion Map(this clsRecepcionDom model)
        {
            return new Recepcion()
            {
                IdRecepcion = model.IdRecepcion,
                IdOrden = model.IdOrden,
                strRecepcion = model.strRecepcion,
                strFactura = model.strFactura,
                strEstado = model.strEstado,
                strObservaciones = model.strObservaciones   
            };
        }

        public static List<Recepcion> Map(this List<clsRecepcionDom> model)
        {
            List<Recepcion> Dtos = new List<Recepcion>();

            foreach (clsRecepcionDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static List<clsRecepcionDom> Map(this List<Recepcion> model)
        {
            List<clsRecepcionDom> Dtos = new List<clsRecepcionDom>();

            foreach (Recepcion modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }
            return Dtos;
        }

        public static clsRecepcionDom Map(this Recepcion DTO)
        {
            return new clsRecepcionDom()
            {
                IdRecepcion = DTO.IdRecepcion,
                IdOrden = DTO.IdOrden,
                strRecepcion = DTO.strRecepcion,
                strFactura = DTO.strFactura,
                strEstado = DTO.strEstado,
                strObservaciones = DTO.strObservaciones
            };
        }

    }
}