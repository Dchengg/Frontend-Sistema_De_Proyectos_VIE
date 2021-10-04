﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    [Serializable]
    [DataContract]
    public class oSubdisciplina
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string DisciplinaCientifica { get; set; }
        [DataMember]
        public string Subdisciplina { get; set; }
    }
}