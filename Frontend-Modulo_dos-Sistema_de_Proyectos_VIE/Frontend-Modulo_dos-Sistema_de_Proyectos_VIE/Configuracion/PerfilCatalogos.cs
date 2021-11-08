using AutoMapper;
using System.Web.Mvc;
using UIProcess.Interfaces;
using UIProcess.Modelos;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Configuracion
{
    public class CatalogoItemConverter : ITypeConverter<ISelectListItem, SelectListItem>
    {
        public SelectListItem Convert(ISelectListItem source, SelectListItem destination, ResolutionContext context)
        {
            return source.ToSelectListItem();
        }
    }

    public class PerfilCatalogos : Profile
    {
        public PerfilCatalogos()
        {
            CreateMap<ISelectListItem, SelectListItem>()
                .ConvertUsing<CatalogoItemConverter>();
            CreateMap<UipCatalogosInvestigador, CatalogosSingleton>();
        }
    }
}