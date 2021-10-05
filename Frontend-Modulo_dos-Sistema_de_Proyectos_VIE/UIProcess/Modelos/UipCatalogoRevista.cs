using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipCatalogoRevista
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NombreRevista { get; set; }
    }
}