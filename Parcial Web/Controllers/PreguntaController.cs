using Microsoft.AspNetCore.Mvc;
using Parcial_Web.Interfaces;
using Parcial_Web.Models;
using System.Diagnostics;

namespace Parcial_Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PreguntaController : Controller
    {
        private readonly IPreguntaService _preguntaService;

        public PreguntaController(IPreguntaService preguntaService)
        {
            _preguntaService = preguntaService;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Pregunta newPregunta)
        {

            var createdPregunta = await _preguntaService.Create(newPregunta);
            return CreatedAtAction(nameof(GetById), new { id = createdPregunta.id_Pregunta}, createdPregunta);

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var pregunta = await _preguntaService.GetById(id);
            return pregunta != null ? Ok(pregunta) : NotFound();
            
        }

        [HttpGet("{estado}")]
        public async Task<IActionResult> GetByStatus(string estado)
        {
            var pregunta = await _preguntaService.GetByStatus(estado);
            return pregunta != null ? Ok(pregunta) : NotFound();
            
        }


    }
}
