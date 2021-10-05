using System.ComponentModel.DataAnnotations;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class IdiomaViewModel
    {
        [Required]
        [Display(Name = "Nombre del idioma")]
        public string NombreIdioma { get; set; }

        [Required]
        [Display(Name = "Nivel de habla")]
        public string NivelHabla { get; set; }

        [Required]
        [Display(Name = "Nivel de lectura")]
        public string NivelLectura { get; set; }

        [Required]
        [Display(Name = "Nivel de escritura")]
        public string NivelEscritura { get; set; }

        [Required]
        [Display(Name = "Idioma materno")]
        public string IdiomaMaterno { get; set; }

    }
}