using Aplicacion.Interfaces;
using Dominio.Modelos;
using Microsoft.AspNetCore.Mvc;
using static API.Maestras.MensajesBase;
using DTO.DTOs;
using DTO.Mappers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        private readonly IServicioProducto<clsProductoDom, int, double> db;

        public ProductoController(IServicioProducto<clsProductoDom, int, double> _db)
        {
            db = _db;
        }

        [HttpGet]
        public ActionResult<List<clsProductoDTO>> ObtenerTodo()
        {
            return Ok(db.ObtenerTodo().Map());
        }

        [HttpGet("{id}")]
        public ActionResult<List<clsProductoDTO>> ObtenetPorID(int id)
        {
            return Ok(db.ObtenerPorID(id).Map());
        }

        [HttpPost]
        public ActionResult Insertar([FromBody] clsProductoDTO entidad)
        {
            db.Insertar(entidad.Map());
            return Ok(Satisfactorio.Insertado.GetEnumDescription());

        }

        [HttpPut("{id}")]
        public ActionResult Actualizar([FromBody] clsProductoDTO entidad)
        {
            //entidad.IdProducto = id;
            db.Actualizar(entidad.Map());
            return Ok(Satisfactorio.Actualizado.GetEnumDescription());
        }

        [HttpPut("ActualizarCantidad")]
        public ActionResult ActualizarCantidad([FromBody] clsProductoDTO entidad)
        {
            db.ActualizarCant(entidad.IdProducto, entidad.numCantidad);
            return Ok(Satisfactorio.Actualizado.GetEnumDescription());
        }

        [HttpDelete("{id}")]
        public void Eliminar(int id)
        {
            db.Eliminar(id);
        }
    }
}
