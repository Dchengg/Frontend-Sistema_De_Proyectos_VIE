using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    [DataContract]
    [Serializable]
    public class oEstudioRealizado
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string TituloAcademico { get; set; }

        [DataMember]
        public int AnoGraduacion { get; set; }

        [DataMember]
        public string NombrePais { get; set; }

        [DataMember]
        public string AreaEstudio { get; set; }

        [DataMember]
        public string NombreIsntitucion { get; set; }
    }
}