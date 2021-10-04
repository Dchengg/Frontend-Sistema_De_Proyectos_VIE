using System;
using System.Runtime.Serialization;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.Inicio
{
    [Serializable]
    [DataContract]
    public class mCatalogoEditorial
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NombreEditorial { get; set; }
    }
}