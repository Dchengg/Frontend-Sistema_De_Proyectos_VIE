using System.ComponentModel.DataAnnotations;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class PatenteViewModel
    {
        [Required]
        [Display(Name = "Nombre de la patente")]
        public string NombrePatente { get; set; }

        [Required]
        [Display(Name = "Número de patente")]
        public string NumeroPatente { get; set; }

        [Required]
        [Display(Name = "Lugar de inscripción")]
        public string LugarInscripcion { get; set; }

        [Required]
        [Display(Name = "Año de inscripción")]
        public int AnoInscripcion { get; set; }
    }
}