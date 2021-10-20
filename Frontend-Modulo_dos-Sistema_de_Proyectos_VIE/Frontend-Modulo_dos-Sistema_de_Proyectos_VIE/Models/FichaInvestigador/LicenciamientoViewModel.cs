using System.ComponentModel.DataAnnotations;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class LicenciamientoViewModel
    {
        [Required]
        [Display(Name = "Producto licenciado")]
        public string ProductoLicenciado { get; set; }

        [Required]
        [Display(Name = "Licenciado(a)")]
        public string PersonaConLicenciamiento { get; set; }

        [Required]
        [Display(Name = "Año")]
        public int Ano { get; set; }

    }
}