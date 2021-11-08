using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class UnidadAcademicaViewModel
    {
        [Required]
        [Display(Name = "Unidad académica")]
        public string NombreUnidadAcademica { get; set; }
        public int IdSede { get; set; }
        public string NombreSede { get; set; }
        public int IdUnidadAcademica { get; set; }
        public IEnumerable<SelectListItem> CatalogoUnidadAcademica { get; set; }

    }
}