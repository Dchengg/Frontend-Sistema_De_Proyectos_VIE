using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [DataContract]
    [Serializable]
    public class UipCatalogoIdioma
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NombreIdioma { get; set; }
    }
}