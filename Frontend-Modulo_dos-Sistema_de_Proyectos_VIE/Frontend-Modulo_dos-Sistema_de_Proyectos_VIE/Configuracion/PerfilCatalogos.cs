using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UIProcess.Modelos;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador;
using AutoMapper;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Configuracion
{
    public class PerfilCatalogos : Profile
    {
        public PerfilCatalogos()
        {
            CreateMap<UipCatalogosInvestigador, CatalogosSingleton>();
        }
    }
}