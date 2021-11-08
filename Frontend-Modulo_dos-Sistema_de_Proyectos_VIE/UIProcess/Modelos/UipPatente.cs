using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipPatente
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string NumPatente { get; set; }
        [DataMember]
        public string Lugar { get; set; }
        [DataMember]
        public int Ano { get; set; }
    }
}