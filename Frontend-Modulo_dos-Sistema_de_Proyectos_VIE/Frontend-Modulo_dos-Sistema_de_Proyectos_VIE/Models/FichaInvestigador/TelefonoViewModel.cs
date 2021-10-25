using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class TelefonoViewModel
    {
        [Required]
        [Display(Name = "Tipo de teléfono")]
        public string Tipo { get; set; }
        public int IdTipoTelefono { get; set; }
        public IEnumerable<SelectListItem> CatalogoTipoTelefono { get; set; }

        [Required]
        [Display(Name = "Número de teléfono")]
        public string Numero { get; set; }
    }
}