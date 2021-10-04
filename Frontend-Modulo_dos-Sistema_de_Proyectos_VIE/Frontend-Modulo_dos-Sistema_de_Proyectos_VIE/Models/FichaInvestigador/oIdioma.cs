using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    [DataContract]
    [Serializable]
    public class oIdioma
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string NombreIdioma { get; set; }

        [DataMember]
        public string NivelEscritura { get; set; }

        [DataMember]
        public string NivelHabla { get; set; }

        [DataMember]
        public string NivelLectura { get; set; }

        [DataMember]
        public bool EsMaterno { get; set; }
    }
}