using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [DataContract]
    [Serializable]
    public class UipIdioma
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int IdIdioma { get; set; }

        [DataMember]
        public string NombreIdioma { get; set; }

        [DataMember]
        public string NivelEscritura { get; set; }

        [DataMember]
        public int IdNivelEscritura { get; set; }

        [DataMember]
        public string NivelHabla { get; set; }

        [DataMember]
        public int IdNivelHabla { get; set; }

        [DataMember]
        public string NivelLectura { get; set; }

        [DataMember]
        public int IdNivelLectura { get; set; }

        [DataMember]
        public bool EsMaterno { get; set; }
    }
}