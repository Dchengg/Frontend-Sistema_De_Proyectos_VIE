using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [DataContract]
    [Serializable]
    public class UipEstudioRealizado
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int IdTituloAcademico { get; set; }

        [DataMember]
        public string TituloAcademico { get; set; }

        [DataMember]
        public int AnoGraduacion { get; set; }

        [DataMember]
        public int IdPais { get; set; }

        [DataMember]
        public string NombrePais { get; set; }

        [DataMember]
        public string AreaDeEstudio { get; set; }

        [DataMember]
        public int IdInstitucion { get; set; }

        [DataMember]
        public string NombreInstitucion { get; set; }
    }
}