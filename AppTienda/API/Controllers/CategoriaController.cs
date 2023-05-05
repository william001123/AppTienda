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
    public class CategoriaController : ControllerBase
    {

        private readonly IServicioBase<clsCategoriaDom, int> db;

        public CategoriaController(IServicioBase<clsCategoriaDom, int> _db)
        {
            db = _db;
        }

        [HttpGet]
        public ActionResult<List<clsCategoriaDTO>> ObtenerTodo()
        {
            return Ok(db.ObtenerTodo().Map());
        }

        [HttpGet("{id}")]
        public ActionResult<List<clsCategoriaDTO>> ObtenetPorID(int id)
        {
            return Ok(db.ObtenerPorID(id).Map());
        }

        [HttpPost]
        public ActionResult Insertar([FromBody] clsCategoriaDTO entidad)
        {
            db.Insertar(entidad.Map());
            return Ok(Satisfactorio.Insertado.GetEnumDescription());

        }

        //[HttpPut("{id}")]
        [HttpPut]
        public ActionResult Actualizar([FromBody] clsCategoriaDTO entidad)
        {            
            db.Actualizar(entidad.Map());
            return Ok(Satisfactorio.Actualizado.GetEnumDescription());
        }

        [HttpDelete("{id}")]
        public void Eliminar(int id)
        {
            db.Eliminar(id);
        }

        //[HttpGet("Ultimo")]
        //public ActionResult Ultimo()
        //{

        //    string NumeroCuenta = "OR0001";

        //    NumeroCuenta.Substring(2, 4);

        //    return Ok(NumeroCuenta);
        //}
        
    }
}
