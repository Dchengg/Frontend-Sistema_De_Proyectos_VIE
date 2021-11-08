using System;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipLicenciamiento
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Producto { get; set; }
        [DataMember]
        public string LicenciadoA { get; set; }
        [DataMember]
        public int Ano { get; set; }
    }
}