using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipTelefono
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string IdInvestigador { get; set; }
        [DataMember]
        public int IdTipoTelefono { get; set; }
        [DataMember]
        public string Tipo { get; set; }
        [DataMember]
        public string Numero { get; set; }
    }
}
