﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class CategoriaAcademicaViewModel
    {
        [Required]
        [Display(Name = "Categoría académica")]
        public string NombreCategoria { get; set; }
        public int Id { get; set; }
        public IEnumerable<SelectListItem> CatalogoCategoriaAcademica { get; set; }
    }
}