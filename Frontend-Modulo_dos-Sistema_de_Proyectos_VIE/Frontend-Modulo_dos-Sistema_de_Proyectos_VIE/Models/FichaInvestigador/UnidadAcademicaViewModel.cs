using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UIProcess.Modelos;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class UnidadAcademicaViewModel
    {
        [Required]
        [Display(Name = "Unidad académica")]
        public string UnidadAcademica { get; set; }
        public string Sede { get; set; }
        public int UnidadAcademicaSeleccionada { get; set; }
        public IEnumerable<SelectListItem> CatalogoUnidadesAcademicas { get; set; }
        
    }
}