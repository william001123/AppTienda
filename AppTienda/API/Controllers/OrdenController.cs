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
    public class OrdenController : ControllerBase
    {

        private readonly IServicioActuaEstado<clsOrdenDom, int, string> db;

        public OrdenController(IServicioActuaEstado<clsOrdenDom, int, string> _db)
        {
            db = _db;
        }

        [HttpGet]
        public ActionResult<List<clsOrdenDTO>> ObtenerTodo()
        {
            return Ok(db.ObtenerTodo().Map());
        }

        [HttpGet("{id}")]
        public ActionResult<List<clsOrdenDTO>> ObtenetPorID(int id)
        {
            return Ok(db.ObtenerPorID(id).Map());
        }

        [HttpPost]
        public ActionResult Insertar([FromBody] clsOrdenDTO entidad)
        {
            db.Insertar(entidad.Map());
            return Ok(Satisfactorio.Insertado.GetEnumDescription());

        }

        [HttpPut("ActualizarEstado")]
        public ActionResult ActualizarEstado([FromBody] clsOrdenDTO entidad)
        {
            //entidad.IdOrden = id;
            db.ActualizarEstado(entidad.IdOrden, entidad.strEstado);
            return Ok(Satisfactorio.Actualizado.GetEnumDescription());
        }

        [HttpDelete("{id}")]
        public void Eliminar(int id)
        {
            db.Eliminar(id);
        }
    }
}
