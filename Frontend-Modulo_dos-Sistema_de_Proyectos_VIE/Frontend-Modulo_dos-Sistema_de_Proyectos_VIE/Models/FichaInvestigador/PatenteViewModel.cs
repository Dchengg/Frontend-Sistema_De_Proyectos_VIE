using System.ComponentModel.DataAnnotations;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class PatenteViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre de la patente")]
        public string NombrePatente { get; set; }

        [Required]
        [Display(Name = "Número de patente")]
        public string NumPatente { get; set; }

        [Required]
        [Display(Name = "Lugar de inscripción")]
        public string Lugar { get; set; }

        [Required]
        [Display(Name = "Año de inscripción")]
        public int Ano { get; set; }
    }
}