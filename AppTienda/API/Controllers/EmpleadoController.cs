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
    public class EmpleadoController : ControllerBase
    {

        private readonly IServicioBase<clsEmpleadoDom, int> db;

        public EmpleadoController(IServicioBase<clsEmpleadoDom, int> _db)
        {
            db = _db;
        }

        [HttpGet]
        public ActionResult<List<clsEmpleadoDTO>> ObtenerTodo()
        {
            return Ok(db.ObtenerTodo().Map());
        }

        [HttpGet("{id}")]
        public ActionResult<List<clsEmpleadoDTO>> ObtenetPorID(int id)
        {
            return Ok(db.ObtenerPorID(id).Map());
        }

        [HttpPost]
        public ActionResult Insertar([FromBody] clsEmpleadoDTO entidad)
        {
            db.Insertar(entidad.Map());
            return Ok(Satisfactorio.Insertado.GetEnumDescription());

        }

        [HttpPut("{id}")]
        public ActionResult Actualizar(int id, [FromBody] clsEmpleadoDTO entidad)
        {
            entidad.IdEmpleado = id;
            db.Actualizar(entidad.Map());
            return Ok(Satisfactorio.Actualizado.GetEnumDescription());
        }

        [HttpDelete("{id}")]
        public void Eliminar(int id)
        {
            db.Eliminar(id);
        }
    }
}
