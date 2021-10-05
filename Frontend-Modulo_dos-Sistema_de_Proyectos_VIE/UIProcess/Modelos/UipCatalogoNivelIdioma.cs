using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [DataContract]
    [Serializable]
    public class UipCatalogoNivelIdioma
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string IdNivelIdioma { get; set; }
    }
}