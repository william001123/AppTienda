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
    public class VentaDetalleController : ControllerBase
    {

        private readonly IServicioObteIDEnc<clsVentaDetalleDom, int, List<clsVentaDetalleDom>> db;

        public VentaDetalleController(IServicioObteIDEnc<clsVentaDetalleDom, int, List<clsVentaDetalleDom>> _db)
        {
            db = _db;
        }

        [HttpGet]
        public ActionResult<List<clsVentaDetalleDTO>> ObtenerTodo()
        {
            return Ok(db.ObtenerTodo().Map());
        }

        [HttpGet("{id}")]
        public ActionResult<List<clsVentaDetalleDTO>> ObtenetPorID(int id)
        {
            return Ok(db.ObtenerPorID(id).Map());
        }

        [HttpPost]
        public ActionResult Insertar([FromBody] clsVentaDetalleDTO entidad)
        {
            db.Insertar(entidad.Map());
            return Ok(Satisfactorio.Insertado.GetEnumDescription());

        }

        [HttpPut("{id}")]
        public ActionResult Actualizar(int id, [FromBody] clsVentaDetalleDTO entidad)
        {
            entidad.IdVentaDetalle = id;
            db.Actualizar(entidad.Map());
            return Ok(Satisfactorio.Actualizado.GetEnumDescription());
        }

        [HttpGet("ObtenerPorIDEnc/{idEnc}")]
        public ActionResult<List<clsOrdenDetalleDTO>> ObtenerPorIDEnc(int idEnc)
        {
            return Ok(db.ObtenerPorIDEnc(idEnc).Map());
        }

        [HttpDelete("{id}")]
        public void Eliminar(int id)
        {
            db.Eliminar(id);
        }
    }
}
