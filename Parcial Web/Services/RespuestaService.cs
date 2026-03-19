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

        public async Task<Respuesta> Create(Respuesta newRespuesta, Guid PreguntaId)
        {
            var respuesta = new Respuesta
            {
                contenido = newRespuesta.contenido,
                PreguntaId = PreguntaId,
                fechaCreacion = DateTime.Now
            };

            _context.Respuesta.Add(respuesta);
            await _context.SaveChangesAsync();
            return respuesta;
        }

        public async Task<Respuesta?> GetById(Guid id) => await _context.Respuesta.FindAsync(id);
    }
}