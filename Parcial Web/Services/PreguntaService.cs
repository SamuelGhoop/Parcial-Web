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
                enunciado = newPregunta.enunciado,
                categoria = newPregunta.categoria,
                estado = "Sin resolver",
                isActive = 1
            };

            _context.Pregunta.Add(pregunta);
            await _context.SaveChangesAsync();
            return pregunta;
        }

        public async Task<Pregunta?> GetById(Guid id) => await _context.Pregunta.FindAsync(id);

        public async Task<Pregunta?> GetByStatus(string estado) => await _context.Pregunta.FindAsync(estado);

    }
}
