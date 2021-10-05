using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipCatalogoEditorial
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NombreEditorial { get; set; }
    }
}