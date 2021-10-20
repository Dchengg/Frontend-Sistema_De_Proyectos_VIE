using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipLibro
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Titulo { get; set; }
        [DataMember]
        public int IdEditorial { get; set; }
        [DataMember]
        public string NombreEditorial { get; set; }
        [DataMember]
        public int Ano { get; set; }
        [DataMember]
        public int IdTipoParticipacion { get; set; }
        [DataMember]
        public string TipoParticipacion { get; set; }
    }
}