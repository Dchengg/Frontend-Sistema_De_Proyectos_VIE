using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipNacionalidad
    {
        [DataMember]
        public int IdNacionalidad { get; set; }
        [DataMember]
        public string Nacionalidad { get; set; }
    }
}