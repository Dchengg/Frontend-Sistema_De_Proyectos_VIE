using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipSubdisciplina
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int IdDisciplinaCientifica { get; set; }
        [DataMember]
        public string DisciplinaCientifica { get; set; }
        [DataMember]
        public int IdSubdisciplina { get; set; }
        [DataMember]
        public string Subdisiplina { get; set; }
    }
}