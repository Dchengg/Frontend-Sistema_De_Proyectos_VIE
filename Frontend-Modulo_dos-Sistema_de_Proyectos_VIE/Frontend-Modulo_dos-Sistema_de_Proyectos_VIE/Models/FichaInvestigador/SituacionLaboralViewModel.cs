using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class SituacionLaboralViewModel
    {
        [Required]
        [Display(Name = "Situación laboral")]
        public string SituacionLaboral { get; set; }
        public int SituacionLaboralSeleccionada { get; set; }
        public IEnumerable<SelectListItem> CatalogoSituacionLaboral { get; set; }
    }
}