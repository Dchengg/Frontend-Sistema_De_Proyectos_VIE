using AutoMapper;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Configuracion;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador;
using System.Collections.Generic;
using UIProcess.Modelos;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE
{

    public static class ViewModelMapper
    {
        // Referencia:https://stackoverflow.com/questions/19544133/automapper-multi-object-source-and-one-destination

        /// <summary>
        /// Permite aplicar el mapeo de un objeto sobre otro mapeo
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="mapper"></param>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <returns>El objeto con los dos mapeos realizados.</returns>
        public static TResult MergeInto<TResult>(this IMapper mapper, object item1, object item2)
        {
            return mapper.Map(item2, mapper.Map<TResult>(item1));
        }

        /// <summary>
        /// Mapea los datos del modelo UipInvestigadorConsultar que almacena los datos de la ficha del investigador
        /// recibidos por la API a su modelo de vista correspondiente: FichaInvestigadorViewModel
        /// </summary>
        /// <param name="investigador"></param>
        /// <returns>El modelo para la vista de la ficha del investigador (FichaInvestigadorViewModel) con los datos
        /// del investigador mapeados</returns>
        public static FichaInvestigadorViewModel MapearFichaInvestigador(UipInvestigadorConsultar investigador)
        {
            // Configuracion de Automapper
            var config = new MapperConfiguration(cfg => cfg.AddProfile<PerfilInvestigador>());
            var mapper = config.CreateMapper();
            return mapper.MergeInto<FichaInvestigadorViewModel>(investigador, CatalogosSingleton.Instancia);
        }

        /// <summary>
        /// Mapea los catálogos de la clase CatalogosSingleton al modelo de la vista de la ficha del investigador.
        /// </summary>
        /// <returns>El modelo para la vista de la ficha del investigador (FichaInvestigadorViewModel) con los catálogos
        /// necesarios mapeados.</returns>
        public static FichaInvestigadorViewModel MapearCatalogosFichaInvestigador()
        {
            // Configuracion de Automapper
            var config = new MapperConfiguration(cfg => cfg.AddProfile<PerfilCatalogos>());
            var mapper = config.CreateMapper();
            return mapper.Map<FichaInvestigadorViewModel>(CatalogosSingleton.Instancia);
        }

        /// <summary>
        /// Mapea los datos del modelo UipInvestigadorListar que almacena datos generales de la ficha del investigador
        /// recibidos por la API a su modelo de vista correspondiente: InvestigadorListarViewModel para mostrarlos en 
        /// una lista.
        /// </summary>
        /// <param name="investigadores"></param>
        /// <returns>El modelo de la vista para listar los investigadores registrados en el sistema.</returns>
        public static List<InvestigadorListarViewModel> MapearListaInvestigadores(List<UipInvestigadorListar> investigadores)
        {
            // Configuracion de Automapper
            var config = new MapperConfiguration(cfg => cfg.AddProfile<PerfilInvestigadorListar>());
            var mapper = config.CreateMapper();
            return mapper.Map<List<InvestigadorListarViewModel>>(investigadores);
        }
    }
}