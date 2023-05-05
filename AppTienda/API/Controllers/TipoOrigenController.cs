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
    public class TipoOrigenController : ControllerBase
    {

        private readonly IServicioBase<clsTipoOrigenDom, int> db;

        public TipoOrigenController(IServicioBase<clsTipoOrigenDom, int> _db)
        {
            db = _db;
        }

        [HttpGet]
        public ActionResult<List<clsTipoOrigenDTO>> ObtenerTodo()
        {
            return Ok(db.ObtenerTodo().Map());
        }

        [HttpGet("{id}")]
        public ActionResult<List<clsTipoOrigenDTO>> ObtenetPorID(int id)
        {
            return Ok(db.ObtenerPorID(id).Map());
        }

        [HttpPost]
        public ActionResult Insertar([FromBody] clsTipoOrigenDTO entidad)
        {
            db.Insertar(entidad.Map());
            return Ok(Satisfactorio.Insertado.GetEnumDescription());

        }

        [HttpPut("{id}")]
        public ActionResult Actualizar(int id, [FromBody] clsTipoOrigenDTO entidad)
        {
            entidad.IdTipoOrigen = id;
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
