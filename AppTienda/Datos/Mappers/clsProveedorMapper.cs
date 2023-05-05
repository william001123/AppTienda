
using Datos.Entidades;
using Dominio.Modelos;

namespace Datos.Mappers
{
    public static class clsProveedorMapper
    {
        public static Proveedor Map(this clsProveedorDom model)
        {
            return new Proveedor()
            {
                IdProveedor = model.IdProveedor,
                strNIT = model.strNIT,
                strNombre = model.strNombre,
                strTelefono = model.strTelefono,
                strDireccion = model.strDireccion   
            };
        }

        public static List<Proveedor> Map(this List<clsProveedorDom> model)
        {
            List<Proveedor> Dtos = new List<Proveedor>();

            foreach (clsProveedorDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static List<clsProveedorDom> Map(this List<Proveedor> model)
        {
            List<clsProveedorDom> Dtos = new List<clsProveedorDom>();

            foreach (Proveedor modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsProveedorDom Map(this Proveedor DTO)
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