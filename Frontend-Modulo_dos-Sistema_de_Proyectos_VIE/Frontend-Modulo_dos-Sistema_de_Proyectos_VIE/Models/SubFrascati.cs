﻿using Newtonsoft.Json;
using System;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class SubFrascati
    {
        #region Variables y Constantes
        [JsonProperty("Id")]
        public String Id { get; set; }
        [JsonProperty("IdAreaFrascati")]

        public String IdAreaFrascati { get; set; }
        [JsonProperty("SubArea")]

        public String SubArea { get; set; }
        #endregion
    }
}