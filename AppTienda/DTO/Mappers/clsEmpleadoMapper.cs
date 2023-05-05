
using Dominio.Modelos;
using DTO.DTOs;

namespace DTO.Mappers
{
    public static class clsEmpleadoMapper
    {
        public static clsEmpleadoDTO Map(this clsEmpleadoDom model)
        {
            return new clsEmpleadoDTO()
            {
                IdEmpleado = model.IdEmpleado,
                strDocumento = model.strDocumento, 
                strNombre = model.strNombre
            };
        }

        public static List<clsEmpleadoDTO> Map(this List<clsEmpleadoDom> model)
        {
            List<clsEmpleadoDTO> Dtos = new List<clsEmpleadoDTO>();

            foreach (clsEmpleadoDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsEmpleadoDom Map(this clsEmpleadoDTO DTO)
        {
            return new clsEmpleadoDom()
            {
                IdEmpleado = DTO.IdEmpleado,
                strDocumento = DTO.strDocumento,
                strNombre = DTO.strNombre 
            };
        }

    }
}