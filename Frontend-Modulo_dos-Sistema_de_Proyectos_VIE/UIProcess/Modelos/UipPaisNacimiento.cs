using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipPaisNacimiento
    {
        [DataMember]
        public int IdPaisNacimiento { get; set; }
        [DataMember]
        public string PaisNacimiento { get; set; }
    }
}