using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipCatalogoIndiceRevista
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NombreIndice { get; set; }
    }
}