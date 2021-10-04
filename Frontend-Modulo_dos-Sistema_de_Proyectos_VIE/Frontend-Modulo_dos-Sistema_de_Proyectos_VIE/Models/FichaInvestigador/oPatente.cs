using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    [Serializable]
    [DataContract]
    public class oPatente
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string NumPatente { get; set; }
        [DataMember]
        public string Lugar { get; set; }
        [DataMember]
        public int Ano { get; set; }
    }
}