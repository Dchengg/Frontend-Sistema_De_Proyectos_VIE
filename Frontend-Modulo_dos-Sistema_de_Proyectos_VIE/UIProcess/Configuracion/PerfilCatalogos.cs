using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UIProcess.Modelos;
using AutoMapper;
using System.Web.Mvc;
using UIProcess.Interfaces;

namespace UIProcess.Configuracion
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