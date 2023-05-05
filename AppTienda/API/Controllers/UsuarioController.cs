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
    public class UsuarioController : ControllerBase
    {

        private readonly IServicioObteIDEnc<clsUsuarioDom, int, clsUsuarioDom> db;

        public UsuarioController(IServicioObteIDEnc<clsUsuarioDom, int, clsUsuarioDom> _db)
        {
            db = _db;
        }

        [HttpGet]
        public ActionResult<List<clsUsuarioDTO>> ObtenerTodo()
        {
            return Ok(db.ObtenerTodo().Map());
        }

        [HttpGet("{id}")]
        public ActionResult<List<clsUsuarioDTO>> ObtenetPorID(int id)
        {
            return Ok(db.ObtenerPorID(id).Map());
        }

        [HttpGet("ObtenerPorIDEnc/{idEnc}")]
        public ActionResult<List<clsUsuarioDTO>> ObtenerPorIDEnc(int idEnc)
        {
            return Ok(db.ObtenerPorIDEnc(idEnc).Map());
        }

        [HttpPost]
        public ActionResult Insertar([FromBody] clsUsuarioDTO entidad)
        {
            db.Insertar(entidad.Map());
            return Ok(Satisfactorio.Insertado.GetEnumDescription());

        }

        [HttpPut("{id}")]
        public ActionResult Actualizar(int id, [FromBody] clsUsuarioDTO entidad)
        {
            entidad.UserId = id;
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
