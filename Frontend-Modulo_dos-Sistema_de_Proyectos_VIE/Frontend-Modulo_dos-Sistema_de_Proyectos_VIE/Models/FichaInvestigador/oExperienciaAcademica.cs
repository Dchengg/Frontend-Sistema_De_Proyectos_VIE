using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    [Serializable]
    [DataContract]
    public class oExperienciaAcademica
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Puesto { get; set; }
        [DataMember]
        public string UnidadDepartamental { get; set; }
        [DataMember]
        public int AnoInicio { get; set; }
        [DataMember]
        public int AnoFinalizacion { get; set; }
    }
}