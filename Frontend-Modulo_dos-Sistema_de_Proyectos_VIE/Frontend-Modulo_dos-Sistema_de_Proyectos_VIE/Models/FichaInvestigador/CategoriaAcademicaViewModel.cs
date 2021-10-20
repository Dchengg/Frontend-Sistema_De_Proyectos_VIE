using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UIProcess.Modelos;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class CategoriaAcademicaViewModel
    {
        [Required]
        [Display(Name = "Categoría académica")]
        public string CategoriaAcademica { get; set; }
        public int CategoriaAcademicaSeleccionada { get; set; }
        public IEnumerable<SelectListItem> CatalogoCategoriasAcademicas { get; set; }
    }
}