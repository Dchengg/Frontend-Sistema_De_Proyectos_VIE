using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class ArticuloViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Título del artículo")]
        public string TituloArticulo { get; set; }

        [Required]
        [Display(Name = "Nombre de la revista")]
        public string NombreRevista { get; set; }
        public int IdRevista { get; set; }
        public IEnumerable<SelectListItem> CatalogoRevista { get; set; }

        [Required]
        [Display(Name = "Nombre del índice")]
        public string NombreIndice { get; set; }
        public int IdIndice { get; set; }
        public IEnumerable<SelectListItem> CatalogoIndiceRevista { get; set; }

        [Required]
        [Display(Name = "Volumen")]
        public int Volumen { get; set; }

        [Required]
        [Display(Name = "Número")]
        public int Numero { get; set; }

        [Required]
        [Display(Name = "Año")]
        public int Ano { get; set; }
    }
}