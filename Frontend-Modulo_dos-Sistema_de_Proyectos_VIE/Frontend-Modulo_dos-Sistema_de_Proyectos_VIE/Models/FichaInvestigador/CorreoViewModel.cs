using System.ComponentModel.DataAnnotations;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class CorreoViewModel
    {
        [Required]
        [Display(Name = "Correo elctrónicco")]
        public string Correo { get; set; }
    }
}