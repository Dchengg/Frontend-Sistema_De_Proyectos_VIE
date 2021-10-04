using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    [DataContract]
    [Serializable]
    public class oUnidadAcademica
    {
        [DataMember]
        public int Id;
        [DataMember]
        public string NumeroIdentidad;
        [DataMember]
        public int IdUnidadAcademica { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string NombreSede { get; set; }
    }
}