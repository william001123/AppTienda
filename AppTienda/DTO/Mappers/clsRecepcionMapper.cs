
using Dominio.Modelos;
using DTO.DTOs;
using System.Reflection;

namespace DTO.Mappers
{
    public static class clsRecepcionMapper
    {
        public static clsRecepcionDTO Map(this clsRecepcionDom model)
        {
            return new clsRecepcionDTO()
            {
                IdRecepcion = model.IdRecepcion,
                IdOrden = model.IdOrden,
                strRecepcion = model.strRecepcion,
                strFactura = model.strFactura,
                strEstado = model.strEstado,
                strObservaciones = model.strObservaciones   
            };
        }

        public static List<clsRecepcionDTO> Map(this List<clsRecepcionDom> model)
        {
            List<clsRecepcionDTO> Dtos = new List<clsRecepcionDTO>();

            foreach (clsRecepcionDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsRecepcionDom Map(this clsRecepcionDTO DTO)
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