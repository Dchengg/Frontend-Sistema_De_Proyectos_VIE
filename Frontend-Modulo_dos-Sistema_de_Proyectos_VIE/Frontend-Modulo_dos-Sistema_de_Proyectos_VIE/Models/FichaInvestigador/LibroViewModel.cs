using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class LibroViewModel
    {
        [Required]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Required]
        [Display(Name = "Editorial")]
        public string EditorialSeleccionada { get; set; }
        public IEnumerable<SelectListItem> Editoriales { get; set; }

        [Required]
        [Display(Name = "Año")]
        public int Ano { get; set; }

        [Required]
        [Display(Name = "Tipo de participación en el libro")]
        public string TipoParticipacionSeleccionada { get; set; }
        public IEnumerable<SelectListItem> TiposParticipacion { get; set; }
    }
}