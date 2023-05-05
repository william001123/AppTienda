
using Datos.Entidades;
using Dominio.Modelos;

namespace Datos.Mappers
{
    public static class clsVentaMapper
    {
        public static Venta Map(this clsVentaDom model)
        {
            return new Venta()
            {
                IdVenta = model.IdVenta,
                strVenta = model.strVenta,
                dtFecha = model.dtFecha,
                numTotal = model.numTotal,
                strEstado = model.strEstado
            };
        }

        public static List<Venta> Map(this List<clsVentaDom> model)
        {
            List<Venta> Dtos = new List<Venta>();

            foreach (clsVentaDom modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }
            return Dtos;
        }

        public static List<clsVentaDom> Map(this List<Venta> model)
        {
            List<clsVentaDom> Dtos = new List<clsVentaDom>();

            foreach (Venta modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }
            return Dtos;
        }

        public static clsVentaDom Map(this Venta DTO)
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