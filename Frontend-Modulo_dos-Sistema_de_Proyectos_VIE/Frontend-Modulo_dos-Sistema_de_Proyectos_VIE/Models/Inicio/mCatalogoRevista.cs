﻿using System;
using System.Runtime.Serialization;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.Inicio
{
    [Serializable]
    [DataContract]
    public class mCatalogoRevista
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NombreRevista { get; set; }
    }
}