using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class PremioViewModel
    {
        [Required]
        [Display(Name = "Nombre del premio")]
        public string NombrePremio { get; set; }

        [Required]
        [Display(Name = "Entidad")]
        public string EntidadSeleccionada { get; set; }
        public IEnumerable<SelectListItem> Entidades { get; set; }

        [Required]
        [Display(Name = "Año")]
        public string Ano { get; set; }

        [Required]
        [Display(Name = "Pais")]
        public string PaisSeleccionado { get; set; }
        public IEnumerable<SelectListItem> Paises { get; set; }

    }
}