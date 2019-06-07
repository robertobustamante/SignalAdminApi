using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Model;
using Service;

namespace SiguesCore.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class CableadoController : Controller
    {
        private readonly ICableadoService _servicio;

        public CableadoController(ICableadoService cableadoService)
        {
            _servicio = cableadoService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_servicio.ListarTodo());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_servicio.Listar(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cableado model)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if(identity != null)
            {                
                return Ok(_servicio.Add(model, System.Convert.ToInt32(identity.FindFirst("UserData").Value)));
            }
            return BadRequest(new { message = "Token invalido" });
        }
        [HttpPut]
        public IActionResult Put([FromBody] Cableado model)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                return Ok(_servicio.Update(model, System.Convert.ToInt32(identity.FindFirst("UserData").Value)));
            }
            return BadRequest(new { message = "Token invalido" });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                return Ok(_servicio.Delete(id, System.Convert.ToInt32(identity.FindFirst("UserData").Value)));
            }
            return BadRequest(new { message = "Token invalido" });            
        }
    }
}