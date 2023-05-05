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
    public class MovimientoDetalleController : ControllerBase
    {

        private readonly IServicioMoviDetalle<clsMovimientoDetalleDom, int, List<clsMovimientoDetalleDom>> db;

        public MovimientoDetalleController(IServicioMoviDetalle<clsMovimientoDetalleDom, int, List<clsMovimientoDetalleDom>> _db)
        {
            db = _db;
        }

        [HttpGet]
        public ActionResult<List<clsMovimientoDetalleDTO>> ObtenerTodo()
        {
            return Ok(db.ObtenerTodo().Map());
        }

        [HttpGet("{id}")]
        public ActionResult<List<clsMovimientoDetalleDTO>> ObtenetPorID(int id)
        {
            return Ok(db.ObtenerPorID(id).Map());
        }

        [HttpPost("{id}")]
        public ActionResult Insertar(int id, [FromBody] clsMovimientoDetalleDTO entidad)
        {
            db.Insertar(entidad.Map(), id);
            return Ok(Satisfactorio.Insertado.GetEnumDescription());

        }    
    }
}
