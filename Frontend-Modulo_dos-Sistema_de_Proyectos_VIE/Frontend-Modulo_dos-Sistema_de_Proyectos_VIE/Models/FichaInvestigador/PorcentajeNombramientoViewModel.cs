using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class PorcentajeNombramientoViewModel
    {
        [Required]
        [Display(Name = "Porcentaje de nombramiento")]
        public int PorcentajeNombramientoSeleccionado { get; set; }
        public IEnumerable<SelectListItem> CatalogoPorcentajeNombramiento { get; set; } // Se llena en frontend
    }
}