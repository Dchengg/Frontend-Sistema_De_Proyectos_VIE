using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipCatalogoParticipacionLibro
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string TipoParticipacion { get; set; }
    }
}