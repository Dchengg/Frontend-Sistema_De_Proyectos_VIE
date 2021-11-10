﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class TipoIdentificacionViewModel
    {
        public int IdTipoIdentificacion { get; set; }
        [Required]
        [Display(Name = "Tipo de identificación")]
        public string TipoIdentificacion { get; set; }
        public IEnumerable<SelectListItem> CatalogoTipoIdentificacion { get; set; }
    }
}