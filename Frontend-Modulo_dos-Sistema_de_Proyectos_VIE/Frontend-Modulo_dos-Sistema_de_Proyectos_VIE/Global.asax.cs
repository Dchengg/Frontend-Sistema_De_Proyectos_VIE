using AutoMapper;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using UIProcess.Modelos;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Obtención de los catálogos para su uso en toda la aplicación
            HttpResponseMessage respuesta = GlobalVariables.WebApiClient.GetAsync("Inicio").Result;
            var datosIniciales = respuesta.Content.ReadAsAsync<UipRespuesta<UipCatalogos>>().Result;

            // Ligado de catalogos
            UipCatalogosGlobal.CatalogoTipoIdentificacion = datosIniciales.ObjetoRespuesta.CatalogoTipoIdentificacion.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoPais = datosIniciales.ObjetoRespuesta.CatalogoPais.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoSexo = new List<SelectListItem>()
            {
                new SelectListItem() {Value = "1", Text = "Masculino"},
                new SelectListItem() {Value = "2", Text = "Femenino"},
                new SelectListItem() {Value = "3", Text = "Prefiero no especificar"}
            };
            UipCatalogosGlobal.CatalogoCategoriaAcademica = datosIniciales.ObjetoRespuesta.CatalogoCategoriaAcademica.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoSituacionLaboral = datosIniciales.ObjetoRespuesta.CatalogoSituacionLaboral.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoPorentajeNombramiento = new List<SelectListItem>();
            for (int i = 1; i <= 100; i++)
            {
                UipCatalogosGlobal.CatalogoPorentajeNombramiento.Add( new SelectListItem() { Value = i.ToString(), Text = i.ToString() } );
            }           
            UipCatalogosGlobal.CatalogoInstitucion = datosIniciales.ObjetoRespuesta.CatalogoInstitucion.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoTituloAcademico = datosIniciales.ObjetoRespuesta.CatalogoTituloAcademico.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoIdioma = datosIniciales.ObjetoRespuesta.CatalogoIdioma.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoNivelIdioma = datosIniciales.ObjetoRespuesta.CatalogoNivelIdioma.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoUnidadAcademica = datosIniciales.ObjetoRespuesta.CatalogoUnidadAcademica.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoTipoPerfil = datosIniciales.ObjetoRespuesta.CatalogoTipoPerfil.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoDisciplinaCientifica = datosIniciales.ObjetoRespuesta.CatalogoDisciplinaCientifica.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoEntidad = datosIniciales.ObjetoRespuesta.CatalogoEntidad.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoRevista = datosIniciales.ObjetoRespuesta.CatalogoRevista.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoIndiceRevista = datosIniciales.ObjetoRespuesta.CatalogoIndiceRevista.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoEditorial = datosIniciales.ObjetoRespuesta.CatalogoEditorial.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoParticipacionLibro = datosIniciales.ObjetoRespuesta.CatalogoParticipacionLibro.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoTipoTelefono = datosIniciales.ObjetoRespuesta.CatalogoTipoTelefono.Select(i => i.ToSelectListItem()).ToList();

            // Configuracion de Automapper
            var config = new MapperConfiguration(
                             cfg =>
                             {
                                 // Tipo identificacion
                                 cfg.CreateMap<UipInvestigadorConsultar, TipoIdentificacionViewModel>();
                                 cfg.CreateMap<CatalogosViewModel, TipoIdentificacionViewModel>();

                                 cfg.CreateMap<UipInvestigadorConsultar, FichaInvestigadorViewModel>();

                                 // Pais
                                 cfg.CreateMap<UipInvestigadorConsultar, PaisViewModel>()
                                 .ForMember(d => d.PaisNacimientoSeleccionado, action => action.MapFrom(s => s.IdPaisNacimiento))
                                 .ForMember(d => d.PaisNacimiento, action => action.MapFrom(s => s.PaisNacimiento));
                                 cfg.CreateMap<CatalogosViewModel, PaisViewModel>();

                                 // Nacionalidad
                                 cfg.CreateMap<UipInvestigadorConsultar, NacionalidadViewModel>()
                                 .ForMember(d => d.NacionalidadSeleccionada, action => action.MapFrom(s => s.IdNacionalidad))
                                 .ForMember(d => d.Nacionalidad, action => action.MapFrom(s => s.Nacionalidad));
                                 cfg.CreateMap<CatalogosViewModel, NacionalidadViewModel>()
                                 .ForMember(d => d.CatalogoNacionalidad, action => action.MapFrom(s => s.CatalogoPais));

                                 // Sexo
                                 cfg.CreateMap<UipInvestigadorConsultar, SexoViewModel>()
                                 .ForMember(d => d.SexoSeleccionado, action => action.MapFrom(s => s.Sexo));
                                 cfg.CreateMap<CatalogosViewModel, SexoViewModel>();

                                 // Categoria academica
                                 cfg.CreateMap<UipCategoriaAcademica, CategoriaAcademicaViewModel>()
                                 .ForMember(d => d.CategoriaAcademicaSeleccionada, action => action.MapFrom(s => s.Id))
                                 .ForMember(d => d.CategoriaAcademica, action => action.MapFrom(s => s.NombreCategoria));
                                 cfg.CreateMap<CatalogosViewModel, CategoriaAcademicaViewModel>();

                                 // Unidad academica
                                 cfg.CreateMap<UipUnidadAcademica, UnidadAcademicaViewModel>()
                                 .ForMember(d => d.UnidadAcademicaSeleccionada, action => action.MapFrom(s => s.IdUnidadAcademica))
                                 .ForMember(d => d.UnidadAcademica, action => action.MapFrom(s => s.NombreUnidadAcademica))
                                 .ForMember(d => d.Sede, action => action.MapFrom(s => s.NombreSede));
                                 cfg.CreateMap<CatalogosViewModel, UnidadAcademicaViewModel>()
                                 .ForMember(d => d.CatalogoUnidadesAcademicas, action => action.MapFrom(s => s.CatalogoUnidadAcademica));

                                 // Situacion laboral
                                 cfg.CreateMap<UipInvestigadorConsultar, SituacionLaboralViewModel>()
                                 .ForMember(d => d.SituacionLaboralSeleccionada, action => action.MapFrom(s => s.IdSituacionLaboral))
                                 .ForMember(d => d.SituacionLaboral, action => action.MapFrom(s => s.SituacionLaboral));
                                 cfg.CreateMap<CatalogosViewModel, SituacionLaboralViewModel>();

                                 // Telefono
                                 cfg.CreateMap<UipTelefono, TelefonoViewModel>()
                                 .ForMember(d => d.TipoTelefonoSeleccionado, action => action.MapFrom(s => s.IdTipoTelefono))
                                 .ForMember(d => d.TipoTelefono, action => action.MapFrom(s => s.Tipo))
                                 .ForMember(d => d.Telefono, action => action.MapFrom(s => s.Numero));
                                 cfg.CreateMap<CatalogosViewModel, TelefonoViewModel>();

                                 // Correo
                                 cfg.CreateMap<UipCorreo, CorreoViewModel>();

                                 // Porcentaje de nombramiento
                                 cfg.CreateMap<UipInvestigadorConsultar, PorcentajeNombramientoViewModel>()
                                 .ForMember(d => d.PorcentajeNombramientoSeleccionado, action => action.MapFrom(s => s.PorcentajeNombramiento));
                                 cfg.CreateMap<CatalogosViewModel, PorcentajeNombramientoViewModel>();

                                 // Perfil academico
                                 cfg.CreateMap<UipPerfilAcademico, PerfilAcademicoViewModel>()
                                 .ForMember(d => d.TipoPerfilSeleccionado, action => action.MapFrom(s => s.TipoPerfil))
                                 .ForMember(d => d.Direccion, action => action.MapFrom(s => s.Direccion));
                                 cfg.CreateMap<CatalogosViewModel, PerfilAcademicoViewModel>()
                                 .ForMember(d => d.CatalogoTiposPerfilAcademico, action => action.MapFrom(s => s.CatalogoTipoPerfil));

                                 // Estudio realizado
                                 cfg.CreateMap<UipEstudioRealizado, EstudioRealizadoViewModel>()
                                 .ForMember(d => d.TituloAcademico, action => action.MapFrom(s => s.TituloAcademico))
                                 .ForMember(d => d.Pais, action => action.MapFrom(s => s.NombrePais))
                                 .ForMember(d => d.Institucion, action => action.MapFrom(s => s.NombreInstitucion))
                                 .ForMember(d => d.AreaDeEstudio, action => action.MapFrom(s => s.AreaDeEstudio))
                                 .ForMember(d => d.AnoGraduacion, action => action.MapFrom(s => s.AnoGraduacion));
                                 cfg.CreateMap<UipCatalogoPais, EstudioRealizadoViewModel>();
                                
                             }
            );
            
        }
    }
}
