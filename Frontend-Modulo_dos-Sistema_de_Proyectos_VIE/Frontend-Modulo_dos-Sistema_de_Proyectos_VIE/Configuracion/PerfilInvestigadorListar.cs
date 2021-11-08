using AutoMapper;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador;
using UIProcess.Modelos;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Configuracion
{
    public class PerfilInvestigadorListar : Profile
    {
        public PerfilInvestigadorListar()
        {
            // Tipo identificacion
            CreateMap<UipInvestigadorListar, InvestigadorListarViewModel>();
        }
    }
}