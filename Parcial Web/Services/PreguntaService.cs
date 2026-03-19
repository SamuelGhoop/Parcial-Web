using Azure;
using Parcial_Web.DAO;
using Parcial_Web.Interfaces;
using Parcial_Web.Models;
using System.Diagnostics;

namespace Parcial_Web.Services
{
    public class PreguntaService : IPreguntaService
    {
        private readonly ApplicationDbContext _context;

        public PreguntaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Pregunta> Create(Pregunta newPregunta)
        {
            var pregunta = new Pregunta
            {
                estado = "Sin resolver"
            };

            _context.Pregunta.Add(pregunta);
            await _context.SaveChangesAsync();
            return newPregunta;
        }

        public async Task<Pregunta?> GetById(Guid id) => await _context.Pregunta.FindAsync(id);

        public async Task<Pregunta?> GetByStatus(string estado) => await _context.Pregunta.FindAsync(estado);

    }
}
