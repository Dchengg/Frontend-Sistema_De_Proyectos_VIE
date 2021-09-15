using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace UIProcess.Modelos
{
    [DataContract]
    [Serializable]
    public class oAreaIdioma
    {
        [DataMember]
        public int idAreaIdioma { get; set; }
        [DataMember]
        public string area { get; set; }
    }
}