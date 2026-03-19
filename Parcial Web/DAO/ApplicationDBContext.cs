using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Parcial_Web.Models;
using System.Diagnostics;
using System.Reflection.Emit;
namespace Parcial_Web.DAO
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // ── AGREGAR DBSETS AQUÍ ────────────────────────────
        // public DbSet<Modelo> Modelos { get; set; }

        public DbSet<Pregunta> Pregunta { get; set; }
        public DbSet<Respuesta> Respuesta { get; set; }



    }
}
