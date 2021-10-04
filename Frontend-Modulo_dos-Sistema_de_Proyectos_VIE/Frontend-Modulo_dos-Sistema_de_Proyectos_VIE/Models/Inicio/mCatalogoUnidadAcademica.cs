using System;
using System.Runtime.Serialization;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.Inicio
{
    [DataContract]
    [Serializable]
    public class mCatalogoUnidadAcademica
    {
        [DataMember]
        public int Id;
        [DataMember]
        public string NombreUnidadAcademica;
    }
}