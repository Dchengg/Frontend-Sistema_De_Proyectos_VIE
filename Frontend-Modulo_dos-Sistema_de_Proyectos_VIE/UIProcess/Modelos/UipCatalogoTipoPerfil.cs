using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipCatalogoTipoPerfil
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string TipoPerfil { get; set; }
    }
}