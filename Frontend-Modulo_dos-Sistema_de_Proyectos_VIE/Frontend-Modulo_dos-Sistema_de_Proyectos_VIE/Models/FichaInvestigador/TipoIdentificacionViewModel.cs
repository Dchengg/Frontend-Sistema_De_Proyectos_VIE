using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class TipoIdentificacionViewModel
    {
        [Required]
        [Display(Name = "Tipo de identificación")]
        public int TipoIdentificacionSeleccionado { get; set; }
        public IEnumerable<SelectListItem> CatalogoTipoIdentificacion { get; set; }
    }
}