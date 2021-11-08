using System.ComponentModel.DataAnnotations;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class ParticipacionViewModel
    {
        public int Id { get; set; }
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
        [Display(Name = "Año de finalización")]
        public int AnoFinalizacion { get; set; }
    }
}