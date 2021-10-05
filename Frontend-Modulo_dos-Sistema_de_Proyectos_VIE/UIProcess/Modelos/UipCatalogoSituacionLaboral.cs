using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [DataContract]
    [Serializable]
    public class UipCatalogoSituacionLaboral
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string SituacionLaboral { get; set; }
    }
}