using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipTipoIdentificacion
    {
        [DataMember]
        public int IdTipoIdentificacion { get; set; }
        [DataMember]
        public string TipoIdentificacion { get; set; }
    }
}
