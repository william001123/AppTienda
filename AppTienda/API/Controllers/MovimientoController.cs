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
    public class MovimientoController : ControllerBase
    {

        private readonly IServicioInserList<clsMovimientoDom, int> db;

        public MovimientoController(IServicioInserList<clsMovimientoDom, int> _db)
        {
            db = _db;
        }

        [HttpGet]
        public ActionResult<List<clsMovimientoDTO>> ObtenerTodo()
        {
            return Ok(db.ObtenerTodo().Map());
        }

        [HttpGet("{id}")]
        public ActionResult<List<clsMovimientoDTO>> ObtenetPorID(int id)
        {
            return Ok(db.ObtenerPorID(id).Map());
        }

        [HttpPost]
        public ActionResult Insertar([FromBody] clsMovimientoDTO entidad)
        {
            return Ok(db.Insertar(entidad.Map()).Map());

        } 
    }
}
