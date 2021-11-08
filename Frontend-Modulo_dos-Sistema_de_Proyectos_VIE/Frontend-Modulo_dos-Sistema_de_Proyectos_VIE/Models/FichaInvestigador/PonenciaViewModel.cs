using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class PonenciaViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Required]
        [Display(Name = "Seminario o conferencia")]
        public string Seminario { get; set; }

        [Required]
        [Display(Name = "Año")]
        public int Ano { get; set; }

        [Required]
        [Display(Name = "País")]
        public string NombrePais { get; set; }
        public int IdPais { get; set; }
        public IEnumerable<SelectListItem> CatalogoPais { get; set; }

    }
}