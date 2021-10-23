using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipSituacionLaboral
    {
        [DataMember]
        public int IdSituacionLaboral { get; set; }
        [DataMember]
        public string SituacionLaboral { get; set; }
    }
}