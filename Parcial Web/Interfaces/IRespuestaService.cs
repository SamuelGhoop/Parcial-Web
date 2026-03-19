using Parcial_Web.Models;

namespace Parcial_Web.Interfaces
{
    public interface IRespuestaService
    {
        Task<Respuesta> Create(Respuesta respuesta, Guid PreguntaId);
        Task<Respuesta?> GetById(Guid id);
    }
}
