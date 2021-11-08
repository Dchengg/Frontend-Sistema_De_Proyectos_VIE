using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [DataContract]
    [Serializable]
    public class UipUnidadAcademica
    {
        [DataMember]
        public int Id;
        [DataMember]
        public int IdUnidadAcademica { get; set; }
        [DataMember]
        public string NombreUnidadAcademica { get; set; }
        [DataMember]
        public int IdSede { get; set; }
        [DataMember]
        public string NombreSede { get; set; }
    }
}