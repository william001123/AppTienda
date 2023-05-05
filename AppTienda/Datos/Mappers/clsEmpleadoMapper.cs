
using Datos.Entidades;
using Dominio.Modelos;

namespace Datos.Mappers
{
    public static class clsEmpleadoMapper
    {
        public static Empleado Map(this clsEmpleadoDom model)
        {
            return new Empleado()
            {
                IdEmpleado = model.IdEmpleado,
                strDocumento = model.strDocumento, 
                strNombre = model.strNombre
            };
        }

        public static List<Empleado> Map(this List<clsEmpleadoDom> model)
        {
            List<Empleado> Dtos = new List<Empleado>();

            foreach (clsEmpleadoDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static List<clsEmpleadoDom> Map(this List<Empleado> model)
        {
            List<clsEmpleadoDom> Dtos = new List<clsEmpleadoDom>();

            foreach (Empleado modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsEmpleadoDom Map(this Empleado DTO)
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