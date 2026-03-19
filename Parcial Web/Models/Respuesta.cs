using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Parcial_Web.Models
{
    public class Respuesta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id_Respuesta {  get; set; }

        [Required(ErrorMessage = "Debe ingresar el contenido de la respuesta")]
        [MinLength(2, ErrorMessage = "La cantidad mínima de caracteres es 1")]
        public string contenido { get; set; }

        public DateTime fechaCreacion { get; set; } = DateTime.Now;

        [Required]

        public Guid PreguntaId { get; set; }

        [ForeignKey("PreguntaId")]

        public Pregunta? pregunta { get; set; }

    }
}
