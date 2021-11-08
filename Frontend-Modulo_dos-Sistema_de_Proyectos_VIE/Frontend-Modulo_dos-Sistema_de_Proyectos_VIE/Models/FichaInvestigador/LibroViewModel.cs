using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class LibroViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Required]
        [Display(Name = "Editorial")]
        public string NombreEditorial { get; set; }
        public int IdEditorial { get; set; }
        public IEnumerable<SelectListItem> CatalogoEditorial { get; set; }

        [Required]
        [Display(Name = "Año")]
        public int Ano { get; set; }

        [Required]
        [Display(Name = "Tipo de participación en el libro")]
        public string TipoParticipacion { get; set; }
        public int IdTipoParticipacion { get; set; }
        public IEnumerable<SelectListItem> CatalogoParticipacionLibro { get; set; }
    }
}