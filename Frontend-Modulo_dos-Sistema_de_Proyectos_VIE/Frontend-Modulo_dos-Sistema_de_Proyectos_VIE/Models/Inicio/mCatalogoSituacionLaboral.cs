using System;
using System.Runtime.Serialization;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.Inicio
{
    [DataContract]
    [Serializable]
    public class mCatalogoSituacionLaboral
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string SituacionLaboral { get; set; }
    }
}