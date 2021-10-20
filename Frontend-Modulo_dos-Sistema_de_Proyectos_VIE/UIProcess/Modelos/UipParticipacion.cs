using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipParticipacion
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Puesto { get; set; }
        [DataMember]
        public string Entidad { get; set; }
        [DataMember]
        public int AnoInicio { get; set; }
        [DataMember]
        public int AnoFinalizacion { get; set; }

    }
}