using System.ComponentModel.DataAnnotations;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class ParticipacionViewModel
    {
        [Required]
        [Display(Name = "Puesto")]
        public string Puesto { get; set; }

        [Required]
        [Display(Name = "Entidad")]
        public string Entidad { get; set; }

        [Required]
        [Display(Name = "Año de inicio")]
        public int AnoInicio { get; set; }

        [Required]
        [Display(Name = "Año de termino")]
        public int AnoTermino { get; set; }
    }
}