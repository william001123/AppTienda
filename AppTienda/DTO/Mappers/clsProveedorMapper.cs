
using Dominio.Modelos;
using DTO.DTOs;
using System;
using System.Reflection;

namespace DTO.Mappers
{
    public static class clsProveedorMapper
    {
        public static clsProveedorDTO Map(this clsProveedorDom model)
        {
            return new clsProveedorDTO()
            {
                IdProveedor = model.IdProveedor,
                strNIT = model.strNIT,
                strNombre = model.strNombre,
                strTelefono = model.strTelefono,
                strDireccion = model.strDireccion   
            };
        }

        public static List<clsProveedorDTO> Map(this List<clsProveedorDom> model)
        {
            List<clsProveedorDTO> Dtos = new List<clsProveedorDTO>();

            foreach (clsProveedorDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsProveedorDom Map(this clsProveedorDTO DTO)
        {
            return new clsProveedorDom()
            {
                IdProveedor = DTO.IdProveedor,
                strNIT = DTO.strNIT,
                strNombre = DTO.strNombre,
                strTelefono = DTO.strTelefono,
                strDireccion = DTO.strDireccion
            };
        }

    }
}