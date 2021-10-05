using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [DataContract]
    [Serializable]
    public class UipCatalogoUnidadAcademica
    {
        [DataMember]
        public int Id;
        [DataMember]
        public string NombreUnidadAcademica;
    }
}