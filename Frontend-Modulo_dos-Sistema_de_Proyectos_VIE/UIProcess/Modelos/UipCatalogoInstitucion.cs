using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
    [DataContract]
    [Serializable]
    public class UipCatalogoInstitucion
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NombreInstitucion { get; set; }
    }
}