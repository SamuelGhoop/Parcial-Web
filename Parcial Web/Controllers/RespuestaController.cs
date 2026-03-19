using Microsoft.AspNetCore.Mvc;
using Parcial_Web.Interfaces;
using Parcial_Web.Models;
using Parcial_Web.Services;

namespace Parcial_Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RespuestaController : Controller
    {
        private readonly IRespuestaService _respuestaService;

        public RespuestaController(IRespuestaService respuestaService)
        {
            _respuestaService = respuestaService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("{PreguntaId}")]
        public async Task<IActionResult> Create(Guid PreguntaId, [FromBody] Respuesta respuesta)
        {
            var newRespuesta = await _respuestaService.Create(respuesta, PreguntaId);
            return Ok(newRespuesta);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var respuesta = await _respuestaService.GetById(id);
            return respuesta != null ? Ok(respuesta) : NotFound();
        }
    }
}
