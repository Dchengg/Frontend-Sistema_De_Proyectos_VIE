using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipCorreo
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string IdInvestigador { get; set; }
        [DataMember]
        public string Correo { get; set; }
    }
}
