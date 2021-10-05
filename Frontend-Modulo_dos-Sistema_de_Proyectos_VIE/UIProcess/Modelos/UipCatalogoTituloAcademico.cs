using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [DataContract]
    [Serializable]
    public class UipCatalogoTituloAcademico
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string TituloAcademico { get; set; }
    }
}