using System;
using System.Runtime.Serialization;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.Inicio
{
    [DataContract]
    [Serializable]
    public class mCatalogoIdioma
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NombreIdioma { get; set; }
    }
}