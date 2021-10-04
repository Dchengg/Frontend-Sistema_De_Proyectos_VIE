using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    [Serializable]
    [DataContract]
    public class oCategoriaAcademica
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NombreCategoria { get; set; }

    }
}