using Microsoft.EntityFrameworkCore;
using Parcial_Web.DAO;
using Parcial_Web.Interfaces;
using Parcial_Web.Models;

namespace Parcial_Web.Services
{
    public class RespuestaService : IRespuestaService
    {
        private readonly ApplicationDbContext _context;

        public RespuestaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Respuesta> Create(Respuesta newRespuesta, string PreguntaId)
        {
            var respuesta = new Respuesta
            {
                PreguntaId = PreguntaId,
                estado = "Resuelta",
                fecha_creacion = DateTime.Now
            };

            _context.Respuesta.Add(respuesta);
            await _context.SaveChangesAsync();
            return respuesta;
        }

        public async Task<Pregunta?> GetById(Guid id) => await _context.Pregunta.FindAsync(id);
    }
}