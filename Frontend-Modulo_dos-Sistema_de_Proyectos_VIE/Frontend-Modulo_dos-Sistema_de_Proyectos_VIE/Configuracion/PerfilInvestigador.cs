using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using UIProcess.Modelos;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador;
using System.Web.Mvc;
using UIProcess.Interfaces;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Configuracion
{
    public class TipoIdentificacionResolver : IValueResolver<UipCatalogosInvestigador,
                                                     TipoIdentificacionViewModel,
                                                     IEnumerable<SelectListItem>>
    {
        public IEnumerable<SelectListItem> Resolve(UipCatalogosInvestigador source,
                                                   TipoIdentificacionViewModel destination,
                                                   IEnumerable<SelectListItem> member,
                                                   ResolutionContext context)
        {
            var nuevaLista = new List<SelectListItem>();
            source.CatalogoTipoIdentificacion.ForEach(ti => nuevaLista.Add(ti.ToSelectListItem()));
            return nuevaLista;
        }
    }

    public class PaisNacimientoResolver : IValueResolver<UipCatalogosInvestigador,
                                                     PaisViewModel,
                                                     IEnumerable<SelectListItem>>
    {
        public IEnumerable<SelectListItem> Resolve(UipCatalogosInvestigador source,
                                                   PaisViewModel destination,
                                                   IEnumerable<SelectListItem> member,
                                                   ResolutionContext context)
        {
            var nuevaLista = new List<SelectListItem>();
            source.CatalogoPais.ForEach(ti => nuevaLista.Add(ti.ToSelectListItem()));
            return nuevaLista;
        }
    }
    

    public class NacionalidadResolver : IValueResolver<UipCatalogosInvestigador,
                                                     NacionalidadViewModel,
                                                     IEnumerable<SelectListItem>>
    {
        public IEnumerable<SelectListItem> Resolve(UipCatalogosInvestigador source,
                                                   NacionalidadViewModel destination,
                                                   IEnumerable<SelectListItem> member,
                                                   ResolutionContext context)
        {
            var nuevaLista = new List<SelectListItem>();
            source.CatalogoPais.ForEach(ti => nuevaLista.Add(ti.ToSelectListItem()));
            return nuevaLista;
        }
    }

    public class PerfilInvestigador : Profile
    {

        public PerfilInvestigador()
        {
            // Tipo identificacion
            CreateMap<UipTipoIdentificacion, TipoIdentificacionViewModel>();
            CreateMap<UipCatalogosInvestigador, TipoIdentificacionViewModel>()
               .ForMember(dest => dest.CatalogoTipoIdentificacion, act => act.MapFrom<TipoIdentificacionResolver>());

            // Pais Nacimiento
            CreateMap<UipPaisNacimiento, PaisViewModel>();
            CreateMap<UipCatalogosInvestigador, PaisViewModel>()
                .ForMember(dest => dest.CatalogoPais, act => act.MapFrom<PaisNacimientoResolver>());

            // Nacionalidad
            CreateMap<UipNacionalidad, NacionalidadViewModel>();
            CreateMap<UipCatalogosInvestigador, NacionalidadViewModel>()
                .ForMember(dest => dest.CatalogoNacionalidad, act => act.MapFrom<NacionalidadResolver>());

            // Sexo
            CreateMap<UipInvestigadorConsultar, SexoViewModel>();

            CreateMap<UipInvestigadorConsultar, FichaInvestigadorViewModel>();
        }

        
    }
}
