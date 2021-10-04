using System;
using System.Runtime.Serialization;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.Inicio
{
    [Serializable]
    [DataContract]
    public class mCatalogoDisciplinaCientifica
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string DisciplinaCientifica { get; set; }
    }
}