using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial_Web.Models
{
    public class Pregunta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id_Pregunta { get; set; }

        [Required(ErrorMessage = "Debe ingresar la pregunta")]
        [MinLength(2, ErrorMessage = "La cantidad mínima de caracteres es 2")]

        public string enunciado { get; set; }

        [Required(ErrorMessage = "Debe ingresar la categoria de la pregunta")]
        [MinLength(2, ErrorMessage = "La cantidad mínima de caracteres es 2")]

        public string categoria { get; set; }

        public string estado { get; set; } = "Sin resolver";
        public int isActive { get; set; } = 1;


    }
}
