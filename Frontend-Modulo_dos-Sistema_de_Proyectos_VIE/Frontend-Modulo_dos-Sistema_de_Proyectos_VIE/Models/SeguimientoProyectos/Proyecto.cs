using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Proyecto
    {
        public String CodigoProyecto { get; set; }
        public String NombreProyecto { get; set; }
        public String Descripcion { get; set; }
        public String Justificacion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public String ObjetivoGeneral { get; set; }
        public String ObjetivoEspecifico { get; set; }
       
       
    }
}