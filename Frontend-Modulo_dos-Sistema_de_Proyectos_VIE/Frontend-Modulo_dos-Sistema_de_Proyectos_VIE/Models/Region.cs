﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Region
    {
        #region Variables y Constantes
        [JsonProperty("id")]
        public String Id { get; set; }
        [JsonProperty("NombreRegion")]
        public String NombreRegion { get; set; }

        #endregion
    }
}