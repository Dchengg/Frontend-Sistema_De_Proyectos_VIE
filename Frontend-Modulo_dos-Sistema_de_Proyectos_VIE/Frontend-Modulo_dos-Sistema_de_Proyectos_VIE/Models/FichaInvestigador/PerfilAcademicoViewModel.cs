using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class PerfilAcademicoViewModel
    {
        [Display(Name = "Nombre del perfil")]
        public string TipoPerfilSeleccionado { get; set; }
        public IEnumerable<SelectListItem> CatalogoTiposPerfilAcademico { get; set; }
        [Display(Name = "Dirección del perfil")]
        public string Direccion { get; set; }
    }
}