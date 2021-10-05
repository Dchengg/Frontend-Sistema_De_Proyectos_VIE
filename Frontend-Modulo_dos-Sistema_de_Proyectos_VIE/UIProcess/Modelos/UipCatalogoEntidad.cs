using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipCatalogoEntidad
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nombre { get; set; }
    }
}