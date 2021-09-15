using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace UIProcess.Modelos
{
    [DataContract]
    [Serializable]
    public class oCanton
    {
        [DataMember]
        public int idCanton { get; set; }
        [DataMember]
        public int idProvincia { get; set; }
        [DataMember]
        public string nombre { get; set; }
    }
}