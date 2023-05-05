using Dominio.Modelos;
using DTO.DTOs;
using System.Reflection;

namespace DTO.Mappers
{
    public static class clsUsuarioMapper
    {
        public static clsUsuarioDTO Map(this clsUsuarioDom model)
        {
            return new clsUsuarioDTO()
            {
                UserId = model.UserId,
                strContraseña  = model.strContraseña,
                IdEmpleado = model.IdEmpleado,
                strUserName = model.strUserName 
            };
        }

        public static List<clsUsuarioDTO> Map(this List<clsUsuarioDom> model)
        {
            List<clsUsuarioDTO> Dtos = new List<clsUsuarioDTO>();

            foreach (clsUsuarioDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsUsuarioDom Map(this clsUsuarioDTO DTO)
        {
            return new clsUsuarioDom()
            {
                UserId = DTO.UserId,
                strContraseña = DTO.strContraseña,
                IdEmpleado = DTO.IdEmpleado,
                strUserName = DTO.strUserName
            };
        }

    }
}