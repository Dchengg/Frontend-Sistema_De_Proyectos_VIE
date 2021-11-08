using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipPerfilAcademico
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string TipoPerfil { get; set; }
        [DataMember]
        public string Direccion { get; set; }
    }
}
