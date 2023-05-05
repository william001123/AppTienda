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
    public class RecepcionController : ControllerBase
    {

        private readonly IServicioActuaEstado<clsRecepcionDom, int, string> db;

        public RecepcionController(IServicioActuaEstado<clsRecepcionDom, int, string> _db)
        {
            db = _db;
        }

        [HttpGet]
        public ActionResult<List<clsRecepcionDTO>> ObtenerTodo()
        {
            return Ok(db.ObtenerTodo().Map());
        }

        [HttpGet("{id}")]
        public ActionResult<List<clsRecepcionDTO>> ObtenetPorID(int id)
        {
            return Ok(db.ObtenerPorID(id).Map());
        }

        [HttpPost]
        public ActionResult Insertar([FromBody] clsRecepcionDTO entidad)
        {
            db.Insertar(entidad.Map());
            return Ok(Satisfactorio.Insertado.GetEnumDescription());

        }

        [HttpPut("ActualizarEstado")]
        public ActionResult ActualizarEstado([FromBody] clsRecepcionDTO entidad)
        {
            //entidad.IdRecepcion = id;
            db.ActualizarEstado(entidad.IdRecepcion, entidad.strEstado);
            return Ok(Satisfactorio.Actualizado.GetEnumDescription());
        }

        [HttpDelete("{id}")]
        public void Eliminar(int id)
        {
            db.Eliminar(id);
        }
    }
}
