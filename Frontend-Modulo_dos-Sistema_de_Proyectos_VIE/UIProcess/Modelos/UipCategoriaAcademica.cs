using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipCategoriaAcademica
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NombreCategoria { get; set; }
    }
}