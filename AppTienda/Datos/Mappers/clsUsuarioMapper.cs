using Datos.Entidades;
using Dominio.Modelos;

namespace Datos.Mappers
{
    public static class clsUsuarioMapper
    {
        public static Usuario Map(this clsUsuarioDom model)
        {
            return new Usuario()
            {
                UserId = model.UserId,
                strContraseña  = model.strContraseña,
                IdEmpleado = model.IdEmpleado,
                strUserName = model.strUserName 
            };
        }

        public static List<Usuario> Map(this List<clsUsuarioDom> model)
        {
            List<Usuario> Dtos = new List<Usuario>();

            foreach (clsUsuarioDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static List<clsUsuarioDom> Map(this List<Usuario> model)
        {
            List<clsUsuarioDom> Dtos = new List<clsUsuarioDom>();

            foreach (Usuario modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsUsuarioDom Map(this Usuario DTO)
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