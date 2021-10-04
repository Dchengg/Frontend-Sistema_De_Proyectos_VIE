using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    [Serializable]
    [DataContract]
    public class oArticulo
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string TituloArticulo { get; set; }
        [DataMember]
        public string NombreRevista { get; set; }
        [DataMember]
        public string NombreIndice { get; set; }
        [DataMember]
        public int Volumen { get; set; }
        [DataMember]
        public int Numero { get; set; }
        [DataMember]
        public int Ano { get; set; }
    }
}