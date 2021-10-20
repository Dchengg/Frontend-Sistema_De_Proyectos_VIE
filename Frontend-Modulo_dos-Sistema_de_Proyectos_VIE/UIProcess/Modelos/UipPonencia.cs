using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipPonencia
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Titulo { get; set; }
        [DataMember]
        public string Seminario { get; set; }
        [DataMember]
        public int Ano { get; set; }
        [DataMember]
        public int IdPais { get; set; }
        [DataMember]
        public string NombrePais { get; set; }
    }
}