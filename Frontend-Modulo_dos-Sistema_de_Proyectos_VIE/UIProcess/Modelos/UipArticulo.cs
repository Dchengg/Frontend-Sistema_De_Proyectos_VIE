using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipArticulo
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string TituloArticulo { get; set; }
        [DataMember]
        public int IdRevista { get; set; }
        [DataMember]
        public string NombreRevista { get; set; }
        [DataMember]
        public int IdIndice { get; set; }
        [DataMember]
        public string NombreIndice { get; set; }
        [DataMember]
        public int Volumen { get; set; }
        [DataMember]
        public int Numero { get; set; }
        [DataMember]
        public int Ano { get; set; }
    }
}