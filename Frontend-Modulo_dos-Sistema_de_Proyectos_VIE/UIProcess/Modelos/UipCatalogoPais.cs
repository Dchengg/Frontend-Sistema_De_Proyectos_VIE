using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipCatalogoPais
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NombrePais { get; set; }
    }
}