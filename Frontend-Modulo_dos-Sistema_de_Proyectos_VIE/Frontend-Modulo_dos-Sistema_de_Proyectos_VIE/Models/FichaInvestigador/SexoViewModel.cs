using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class SexoViewModel
    {
        [Required]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }
        public IEnumerable<SelectListItem> CatalogoSexo { get; set; }
    }
}