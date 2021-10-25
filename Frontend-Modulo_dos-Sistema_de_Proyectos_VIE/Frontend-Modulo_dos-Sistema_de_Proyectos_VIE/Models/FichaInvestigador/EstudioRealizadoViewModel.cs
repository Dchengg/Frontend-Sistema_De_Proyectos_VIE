using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class EstudioRealizadoViewModel
    {
        [Required]
        [Display(Name = "Título académico")]
        public string TituloAcademico { get; set; }
        public int IdTituloAcademico { get; set; }
        public IEnumerable<SelectListItem> TitulosAcademicos { get; set; }

        [Required]
        [Display(Name = "Institución")]
        public string NombreInstitucion { get; set; }
        public int IdInstitucion { get; set; }
        public IEnumerable<SelectListItem> CatalogoInstitucion { get; set; }

        [Required]
        [Display(Name = "Año de graduación")]
        public int AnoGraduacion { get; set; }

        [Required]
        [Display(Name = "Área de estudio")]
        public string AreaDeEstudio { get; set; }

        [Required]
        [Display(Name = "Pais")]
        public string NombrePais { get; set; }
        public int IdPais { get; set; }
        public IEnumerable<SelectListItem> CatalogoPais { get; set; }
    }
}