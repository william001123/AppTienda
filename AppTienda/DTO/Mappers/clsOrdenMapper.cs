using Dominio.Modelos;
using DTO.DTOs;
using System.Reflection;

namespace DTO.Mappers
{
    public static class clsOrdenMapper
    {
        public static clsOrdenDTO Map(this clsOrdenDom model)
        {
            return new clsOrdenDTO()
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

        public static List<clsOrdenDTO> Map(this List<clsOrdenDom> model)
        {
            List<clsOrdenDTO> Dtos = new List<clsOrdenDTO>();

            foreach (clsOrdenDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsOrdenDom Map(this clsOrdenDTO DTO)
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