using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class PaisViewModel
    {
        [Required]
        [Display(Name = "País de nacimiento")]
        public int PaisNacimientoSeleccionado { get; set; }
        public IEnumerable<SelectListItem> CatalogoPais { get; set; }
    }
}