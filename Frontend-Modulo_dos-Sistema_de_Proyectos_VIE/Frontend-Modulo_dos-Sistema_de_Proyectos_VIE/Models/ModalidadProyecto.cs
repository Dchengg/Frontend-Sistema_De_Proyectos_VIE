﻿using Newtonsoft.Json;
using System;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class ModalidadProyecto
    {
        #region Variables y Constantes
        [JsonProperty("Id")]
        public String Id { get; set; }
        [JsonProperty("NombreModalidad")]

        public String Nombre { get; set; }
        #endregion

    }
}