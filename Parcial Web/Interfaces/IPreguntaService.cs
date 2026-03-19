using Parcial_Web.Models;
using System.Diagnostics;

namespace Parcial_Web.Interfaces
{
    public interface IPreguntaService
    {

        Task<Pregunta> Create(Pregunta pregunta);

        Task<Pregunta?> GetById(Guid id);

        Task<Pregunta?> GetByStatus(string estado);

    }
}
