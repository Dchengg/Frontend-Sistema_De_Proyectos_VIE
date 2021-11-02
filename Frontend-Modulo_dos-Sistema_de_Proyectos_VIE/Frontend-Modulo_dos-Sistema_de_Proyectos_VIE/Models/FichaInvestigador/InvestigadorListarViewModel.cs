using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class InvestigadorListarViewModel
    {
        [Display(Name = "Numero de identidad")]
        public string NumeroIdentidad { get; set; }
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Display(Name = "Primer apellido")]
        public string PrimerApellido { get; set; }
        [Display(Name = "Fotografía")]
        public byte[] Fotografia { get; set; }
    }
}