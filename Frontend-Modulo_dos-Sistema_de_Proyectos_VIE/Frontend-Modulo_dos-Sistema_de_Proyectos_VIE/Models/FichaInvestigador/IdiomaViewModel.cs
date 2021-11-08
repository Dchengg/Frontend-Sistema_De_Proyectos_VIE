using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class IdiomaViewModel
    {
        [Required]
        [Display(Name = "Nombre del idioma")]
        public string NombreIdioma { get; set; }
        public int IdIdioma { get; set; }
        public IEnumerable<SelectListItem> CatalogoIdiomas { get; set; }

        [Required]
        [Display(Name = "Nivel de habla")]
        public string NivelHabla { get; set; }
        public int IdNivelHabla { get; set; }
        public IEnumerable<SelectListItem> CatalogoNivelHabla { get; set; }

        [Required]
        [Display(Name = "Nivel de lectura")]
        public string NivelLectura { get; set; }
        public int IdNivelLectura { get; set; }
        public IEnumerable<SelectListItem> CatalogoNivelLectura { get; set; }

        [Required]
        [Display(Name = "Nivel de escritura")]
        public string NivelEscritura { get; set; }
        public int IdNivelEscritura { get; set; }
        public IEnumerable<SelectListItem> CatalogoNivelEscritura { get; set; }

        [Required]
        [Display(Name = "Idioma materno")]
        public bool IdiomaMaterno { get; set; }


    }
}