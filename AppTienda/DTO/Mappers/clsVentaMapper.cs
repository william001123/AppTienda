
using Dominio.Modelos;
using DTO.DTOs;
using System.Reflection;

namespace DTO.Mappers
{
    public static class clsVentaMapper
    {
        public static clsVentaDTO Map(this clsVentaDom model)
        {
            return new clsVentaDTO()
            {
                IdVenta = model.IdVenta,
                strVenta = model.strVenta,
                dtFecha = model.dtFecha,
                numTotal = model.numTotal,
                strEstado = model.strEstado
            };
        }

        public static List<clsVentaDTO> Map(this List<clsVentaDom> model)
        {
            List<clsVentaDTO> Dtos = new List<clsVentaDTO>();

            foreach (clsVentaDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsVentaDom Map(this clsVentaDTO DTO)
        {
            return new clsVentaDom()
            {
                IdVenta = DTO.IdVenta,
                strVenta = DTO.strVenta,
                dtFecha = DTO.dtFecha,
                numTotal = DTO.numTotal,
                strEstado = DTO.strEstado
            };
        }

    }
}