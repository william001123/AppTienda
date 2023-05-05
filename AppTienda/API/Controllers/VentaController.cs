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
    public class VentaController : ControllerBase
    {

        private readonly IServicioActuaEstado<clsVentaDom, int, string> db;

        public VentaController(IServicioActuaEstado<clsVentaDom, int, string> _db)
        {
            db = _db;
        }

        [HttpGet]
        public ActionResult<List<clsVentaDTO>> ObtenerTodo()
        {
            return Ok(db.ObtenerTodo().Map());
        }

        [HttpGet("{id}")]
        public ActionResult<List<clsVentaDTO>> ObtenetPorID(int id)
        {
            return Ok(db.ObtenerPorID(id).Map());
        }

        [HttpPost]
        public ActionResult<clsVentaDTO> Insertar([FromBody] clsVentaDTO entidad)
        {            
            return Ok(db.Insertar(entidad.Map()).Map());
        }

        [HttpPut("{id}")]
        public ActionResult ActualizarEstado(int id, [FromBody] clsVentaDTO entidad)
        {
            entidad.IdVenta = id;
            db.ActualizarEstado(entidad.IdVenta, entidad.strEstado);
            return Ok(Satisfactorio.Actualizado.GetEnumDescription());
        }

        [HttpDelete("{id}")]
        public void Eliminar(int id)
        {
            db.Eliminar(id);
        }
    }
}
