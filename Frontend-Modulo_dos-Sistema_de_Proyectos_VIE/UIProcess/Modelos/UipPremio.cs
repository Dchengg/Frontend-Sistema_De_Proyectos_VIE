using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipPremio
    {
        [DataMember]
        public string NombrePremio { get; set; }
        [DataMember]
        public string Entidad { get; set; }
        [DataMember]
        public int Ano { get; set; }
        [DataMember]
        public string Pais { get; set; }

    }
}