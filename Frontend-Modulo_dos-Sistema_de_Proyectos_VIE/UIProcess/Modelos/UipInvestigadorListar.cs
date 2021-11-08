using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipInvestigadorListar
    {
        [DataMember]
        public string NumeroIdentidad { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string PrimerApellido { get; set; }
        [DataMember]
        public byte[] Fotografia { get; set; }
    }
}
