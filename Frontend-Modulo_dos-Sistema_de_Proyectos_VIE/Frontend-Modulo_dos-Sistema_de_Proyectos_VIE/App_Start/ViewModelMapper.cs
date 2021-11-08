using AutoMapper;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Configuracion;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UIProcess.Modelos;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE
{

    public static class ViewModelMapper
    {
        public static TResult MergeInto<TResult>(this IMapper mapper, object item1, object item2)
        {
            return mapper.Map(item2, mapper.Map<TResult>(item1));
        }

        public static FichaInvestigadorViewModel MapearFichaInvestigador(UipInvestigadorConsultar investigador)
        {
            // Configuracion de Automapper
            var config = new MapperConfiguration(cfg => cfg.AddProfile<PerfilInvestigador>());
            var mapper = config.CreateMapper();
            return mapper.MergeInto<FichaInvestigadorViewModel>(investigador, CatalogosSingleton.Instancia);
        }

        public static FichaInvestigadorViewModel MapearCatalogosFichaInvestigador()
        {
            // Configuracion de Automapper
            var config = new MapperConfiguration(cfg => cfg.AddProfile<PerfilCatalogos>());
            var mapper = config.CreateMapper();
            return mapper.Map<FichaInvestigadorViewModel>(CatalogosSingleton.Instancia);
        }

        public static List<InvestigadorListarViewModel> MapearListaInvestigadores(List<UipInvestigadorListar> investigadores)
        {
            // Configuracion de Automapper
            var config = new MapperConfiguration(cfg => cfg.AddProfile<PerfilInvestigadorListar>());
            var mapper = config.CreateMapper();
            return mapper.Map<List<InvestigadorListarViewModel>>(investigadores);
        }
    }
}