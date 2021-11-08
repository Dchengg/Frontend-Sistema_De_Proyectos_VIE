using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class PaisViewModel
    {
        public int IdPaisNacimiento { get; set; }
        [Required]
        [Display(Name = "País de nacimiento")]
        public string PaisNacimiento { get; set; }
        public IEnumerable<SelectListItem> CatalogoPais { get; set; }
    }
}