using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace UIProcess.Modelos
{
    [DataContract]
    [Serializable]
    public class oAreaEstudio
    {
        [DataMember]
        public int idAreaEstudio { get; set; }
        [DataMember]
        public string area { get; set; }
    }
}