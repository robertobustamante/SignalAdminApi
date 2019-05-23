using Microsoft.AspNetCore.Mvc;
using Model;
using Service;

namespace SiguesCore.Controllers
{
    [Route("api/[controller]")]
    public class MaterialController : Controller
    {
        private readonly IMaterialService _materialService;

        public MaterialController(IMaterialService materialService)
        {
            _materialService = materialService;
        }

        // GET api/values
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_materialService.ListarTodo());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_materialService.Listar(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Material model)
        {
            return Ok(_materialService.Add(model));
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody] Material model)
        {
            return Ok(_materialService.Add(model));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //return Ok(_materialService.Delete(id));
            return Ok();
        }
    }
}
