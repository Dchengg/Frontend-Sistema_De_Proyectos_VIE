using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipPerfilAcademico
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string TipoPerfil { get; set; }
        [DataMember]
        public string Direccion { get; set; }
    }
}
