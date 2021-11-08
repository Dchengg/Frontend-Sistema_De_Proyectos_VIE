using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class NacionalidadViewModel
    {
        public int IdNacionalidad { get; set; }
        [Required]
        [Display(Name = "Nacionalidad")]
        public string Nacionalidad { get; set; }
        public IEnumerable<SelectListItem> CatalogoPais { get; set; }
    }
}