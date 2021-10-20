using System.ComponentModel.DataAnnotations;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class SoftwareViewModel
    {
        [Required]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Required]
        [Display(Name = "Año")]
        public int Ano { get; set; }

        [Required]
        [Display(Name = "Plataforma")]
        public string Plataforma { get; set; }
    }
}