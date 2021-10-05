using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipCatalogoDisciplinaCientifica
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string DisciplinaCientifica { get; set; }
    }
}