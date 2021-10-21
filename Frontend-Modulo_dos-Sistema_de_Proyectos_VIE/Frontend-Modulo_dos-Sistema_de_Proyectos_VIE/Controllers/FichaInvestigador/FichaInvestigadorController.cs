using AutoMapper;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using UIProcess.Modelos;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Controllers.FichaInvestigador
{
    public class FichaInvestigadorController : Controller
    {
        // GET: FichaInvestigador
        public ActionResult Index()
        {
            return View();
        }

        // GET: FichaInvestigador/Details/5
        public ActionResult Details(string id)
        {
            HttpResponseMessage respuestaHtml = GlobalVariables.WebApiClient.GetAsync("Investigador/"+id.ToString()).Result;
            var respuesta = respuestaHtml.Content.ReadAsAsync<UipRespuesta<UipInvestigadorConsultar>>().Result;

            FichaInvestigadorViewModel objetoVista = new FichaInvestigadorViewModel();

            var investigador = respuesta.ObjetoRespuesta;

            #region Mapeo manual del objeto de consulta al objeto de la vista
            objetoVista.Fotografia = investigador.Fotografia;
            objetoVista.Nombre = investigador.Nombre;
            objetoVista.PrimerApellido = investigador.PrimerApellido;
            objetoVista.SegundoApellido = investigador.SegundoApellido;
            objetoVista.FechaNacimiento = investigador.FechaNacimiento;

            // Tipo identificacion
            var catTipoIdentificacion = UipCatalogosGlobal.CatalogoTipoIdentificacion;
            catTipoIdentificacion.ForEach(i => i.Selected = false);
            catTipoIdentificacion.First(i => i.Value == investigador.IdTipoIdentificacion.ToString()).Selected = true;

            objetoVista.TipoIdentificacionViewModel = new TipoIdentificacionViewModel
            {
                IdTipoIdentificacion = investigador.IdTipoIdentificacion,
                CatalogoTipoIdentificacion = catTipoIdentificacion
            };

            // Pais de nacimiento
            var catPais = UipCatalogosGlobal.CatalogoPais;
            catPais.ForEach(i => i.Selected = false);
            catPais.First(i => i.Value == investigador.IdPaisNacimiento.ToString()).Selected = true;
            objetoVista.PaisViewModel = new PaisViewModel
            {
                PaisNacimientoSeleccionado = investigador.IdPaisNacimiento,
                CatalogoPais = catPais
            };

            // Nacionalidad
            var catNacionalidad = UipCatalogosGlobal.CatalogoPais;
            catNacionalidad.ForEach(i => i.Selected = false);
            catNacionalidad.First(i => i.Value == investigador.IdNacionalidad.ToString()).Selected = true;

            objetoVista.NacionalidadViewModel = new NacionalidadViewModel
            {
                NacionalidadSeleccionada = investigador.IdNacionalidad,
                CatalogoNacionalidad = catNacionalidad
            };

            // Catalogo pais
            objetoVista.CatalogoPais = UipCatalogosGlobal.CatalogoPais;

            // Sexo
            var catSexo = UipCatalogosGlobal.CatalogoSexo;
            catSexo.ForEach(i => i.Selected = false);
            catSexo.First(i => i.Text == investigador.Sexo).Selected = true;

            objetoVista.SexoViewModel = new SexoViewModel
            {
                SexoSeleccionado = investigador.Sexo,
                CatalogoSexo = catSexo
            };

            // Apartado postal
            objetoVista.ApartadoPostal = investigador.ApartadoPostal;

            // Numero identidad
            objetoVista.NumeroIdentidad = investigador.NumeroIdentidad;

            // Seudonimo
            objetoVista.Seudonimo = investigador.Seudonimo;

            // Categorias academicas
            objetoVista.CategoriasAcademicas = new List<CategoriaAcademicaViewModel>();
            foreach (var categoriaAcademica in investigador.CategoriasAcademicas)
            {
                var catCategoriasAcademicas = UipCatalogosGlobal.CatalogoCategoriaAcademica;
                catCategoriasAcademicas.ForEach(i => i.Selected = false);
                catCategoriasAcademicas.First(i => i.Value == categoriaAcademica.Id.ToString()).Selected = true;

                objetoVista.CategoriasAcademicas.Add(new CategoriaAcademicaViewModel()
                {
                    CategoriaAcademicaSeleccionada = (categoriaAcademica.Id - 1),
                    CatalogoCategoriasAcademicas = catCategoriasAcademicas
                });
            }

            // Unidades academicas
            objetoVista.UnidadesAcademicas = new List<UnidadAcademicaViewModel>();
            foreach (var unidadAcademica in investigador.UnidadesAcademicas)
            {
                var catUnidadesAcademicas = UipCatalogosGlobal.CatalogoUnidadAcademica;
                catUnidadesAcademicas.ForEach(i => i.Selected = false);
                catUnidadesAcademicas.First(i => i.Value == unidadAcademica.IdUnidadAcademica.ToString()).Selected = true;
                objetoVista.UnidadesAcademicas.Add(new UnidadAcademicaViewModel()
                {
                    UnidadAcademicaSeleccionada = unidadAcademica.Id,
                    UnidadAcademica = unidadAcademica.NombreUnidadAcademica,
                    CatalogoUnidadesAcademicas = catUnidadesAcademicas
                });
            }

            // Fecha de ingreso a institucion
            objetoVista.FechaDeIngresoInstitucion = investigador.FechaDeIngresoInstitucion;

            // Situacion laboral
            var catSituacionLaboral = UipCatalogosGlobal.CatalogoSituacionLaboral;
            catSituacionLaboral.ForEach(i => i.Selected = false);
            catSituacionLaboral.First(i => i.Value == investigador.IdSituacionLaboral.ToString()).Selected = true;

            objetoVista.SituacionLaboralViewModel = new SituacionLaboralViewModel()
            {
                SituacionLaboralSeleccionada = investigador.IdSituacionLaboral,
                CatalogoSituacionLaboral = catSituacionLaboral
            };

            // Telefonos
            objetoVista.Telefonos = new List<TelefonoViewModel>();
            foreach (var telefono in investigador.Telefonos)
            {
                var catTelefonos = UipCatalogosGlobal.CatalogoTipoTelefono;
                catTelefonos.ForEach(i => i.Selected = false);
                catTelefonos.First(i => i.Value == telefono.IdTipoTelefono.ToString()).Selected = true;

                objetoVista.Telefonos.Add(new TelefonoViewModel()
                {
                    Telefono = telefono.Numero,
                    TipoTelefono = telefono.Tipo,
                    CatalogoTipoTelefono = catTelefonos
                });
            }

            // Catalogo de telefonos
            objetoVista.CatalogoTipoTelefono = UipCatalogosGlobal.CatalogoTipoTelefono;

            // Correos
            objetoVista.Correos = new List<CorreoViewModel>();
            foreach (var correo in investigador.Correos)
            {
                objetoVista.Correos.Add(new CorreoViewModel()
                {
                    Correo = correo.Correo
                });
            }

            // Porcentaje de nombramieto
            var catPorcetajeNombramiento = UipCatalogosGlobal.CatalogoPorentajeNombramiento;
            catPorcetajeNombramiento.ForEach(i => i.Selected = false);
            catPorcetajeNombramiento.First(i => i.Value == investigador.PorcentajeNombramiento.ToString()).Selected = true;
            objetoVista.PorcentajeNombramientoViewModel = new PorcentajeNombramientoViewModel()
            {
                PorcentajeNombramientoSeleccionado = investigador.PorcentajeNombramiento,
                CatalogoPorcentajeNombramiento = UipCatalogosGlobal.CatalogoPorentajeNombramiento
            };

            objetoVista.PerfilesAcademicos = new List<PerfilAcademicoViewModel>();
            {
                foreach (var perfilAcademico in investigador.PerfilesAcademicos)
                {
                    objetoVista.PerfilesAcademicos.Add(new PerfilAcademicoViewModel()
                    {
                        TipoPerfilSeleccionado = perfilAcademico.TipoPerfil,
                        CatalogoTiposPerfilAcademico = UipCatalogosGlobal.CatalogoTipoPerfil,
                        Direccion = perfilAcademico.Direccion
                    });
                }
            }

            // Estudios realizados
            objetoVista.EstudiosRealizados = new List<EstudioRealizadoViewModel>();
            foreach (var estudioRealizado in investigador.EstudiosRealizados)
            {

                objetoVista.EstudiosRealizados.Add(new EstudioRealizadoViewModel()
                {
                    IdTituloAcademico = estudioRealizado.IdTituloAcademico,
                    TituloAcademico = estudioRealizado.TituloAcademico,
                    TitulosAcademicos = UipCatalogosGlobal.CatalogoTituloAcademico,
                    IdInstitucion = estudioRealizado.IdInstitucion,
                    Institucion = estudioRealizado.NombreInstitucion,
                    Instituciones = UipCatalogosGlobal.CatalogoInstitucion,
                    AnoGraduacion = estudioRealizado.AnoGraduacion,
                    AreaDeEstudio = estudioRealizado.AreaDeEstudio,
                    IdPais = estudioRealizado.IdPais,
                    Pais = estudioRealizado.NombrePais,
                    Paises = UipCatalogosGlobal.CatalogoPais
                }); ;
            }

            // Catalogo instituciones
            objetoVista.CatalogoInstitucion = UipCatalogosGlobal.CatalogoInstitucion;

            // Idiomas
            objetoVista.Idiomas = new List<IdiomaViewModel>();
            foreach (var idioma in investigador.Idiomas)
            {
                var catIdioma = UipCatalogosGlobal.CatalogoIdioma;
                catIdioma.ForEach(i => i.Selected = false);
                catIdioma.First(i => i.Value == idioma.IdIdioma.ToString()).Selected = true;

                var catNivelHabla = UipCatalogosGlobal.CatalogoNivelIdioma;
                catNivelHabla.ForEach(i => i.Selected = false);
                catNivelHabla.First(i => i.Value == idioma.IdNivelHabla.ToString()).Selected = true;

                var catNivelEscritura = UipCatalogosGlobal.CatalogoNivelIdioma;
                catNivelEscritura.ForEach(i => i.Selected = false);
                catNivelEscritura.First(i => i.Value == idioma.IdNivelEscritura.ToString()).Selected = true;

                var catNivelLectura = UipCatalogosGlobal.CatalogoNivelIdioma;
                catNivelLectura.ForEach(i => i.Selected = false);
                catNivelLectura.First(i => i.Value == idioma.IdNivelLectura.ToString()).Selected = true;

                objetoVista.Idiomas.Add(new IdiomaViewModel()
                {
                    NombreIdioma = idioma.NombreIdioma,
                    IdIdioma = idioma.IdIdioma,
                    CatalogoIdiomas = UipCatalogosGlobal.CatalogoIdioma,
                    NivelHabla = idioma.NivelHabla,
                    IdNivelHabla = idioma.IdNivelHabla,
                    CatalogoNivelHabla = UipCatalogosGlobal.CatalogoNivelIdioma,
                    NivelEscritura = idioma.NivelEscritura,
                    IdNivelEscritura = idioma.IdNivelEscritura,
                    CatalogoNivelEscritura = UipCatalogosGlobal.CatalogoNivelIdioma,
                    NivelLectura = idioma.NivelLectura,
                    IdNivelLectura = idioma.IdNivelLectura,
                    CatalogoNivelLectura = UipCatalogosGlobal.CatalogoNivelIdioma,
                    IdiomaMaterno = idioma.EsMaterno
                }); ;
            }

            // Catalogo idioma
            objetoVista.CatalogoIdioma = UipCatalogosGlobal.CatalogoIdioma;

            // Catalogo nivel idioma
            objetoVista.CatalogoNivelIdioma = UipCatalogosGlobal.CatalogoNivelIdioma;

            // Catalogo experiencias academicas
            objetoVista.ExperienciaAcademicas = new List<ExperienciaAcademicaViewModel>();
            foreach (var experienciaAcademica in investigador.ExperienciasAcademicas)
            {
                objetoVista.ExperienciaAcademicas.Add(new ExperienciaAcademicaViewModel()
                {
                    Puesto = experienciaAcademica.Puesto,
                    AnoInicio = experienciaAcademica.AnoInicio,
                    AnoTermino = experienciaAcademica.AnoFinalizacion,
                    UnidadDepartametal = experienciaAcademica.UnidadDepartamental
                });
            }

            // Participaciones de proyectos, etc.
            objetoVista.Participaciones = new List<ParticipacionViewModel>();
            foreach (var participacion in investigador.Participaciones)
            {
                objetoVista.Participaciones.Add(new ParticipacionViewModel()
                {
                    Puesto = participacion.Puesto,
                    Entidad = participacion.Entidad,
                    AnoInicio = participacion.AnoInicio,
                    AnoTermino = participacion.AnoFinalizacion
                });
            }

            // Premios
            objetoVista.Premios = new List<PremioViewModel>();
            foreach (var premio in investigador.Premios)
            {
                var catEntidades = UipCatalogosGlobal.CatalogoEntidad;
                catEntidades.ForEach(i => i.Selected = false);
                catEntidades.First(i => i.Value == premio.Entidad).Selected = true;

                var catPaisPremio = UipCatalogosGlobal.CatalogoPais;
                catPaisPremio.ForEach(i => i.Selected = false);
                catPaisPremio.First(i => i.Value == premio.Pais).Selected = true;

                objetoVista.Premios.Add(new PremioViewModel()
                {
                    NombrePremio = premio.NombrePremio,
                    EntidadSeleccionada = premio.Entidad,
                    Entidades = catEntidades,
                    Ano = premio.Ano,
                    PaisSeleccionado = premio.Pais,
                    Paises = catPaisPremio
                });
            }

            // Catalogo entidades
            objetoVista.CatalogoEntidades = UipCatalogosGlobal.CatalogoEntidad;

            // Articulos
            objetoVista.Articulos = new List<ArticuloViewModel>();
            foreach (var articulo in investigador.Articulos)
            {
                var catRevistas = UipCatalogosGlobal.CatalogoRevista;
                catRevistas.ForEach(i => i.Selected = false);
                catRevistas.First(i => i.Value == articulo.IdRevista.ToString()).Selected = true;

                var catIndiceRevista = UipCatalogosGlobal.CatalogoIndiceRevista;
                catIndiceRevista.ForEach(i => i.Selected = false);
                catIndiceRevista.First(i => i.Value == articulo.IdIndice.ToString()).Selected = true;

                objetoVista.Articulos.Add(new ArticuloViewModel()
                {
                    TituloArticulo = articulo.TituloArticulo,
                    IdRevista = articulo.IdRevista,
                    NombreRevista = articulo.NombreRevista,
                    CatalogoRevistas = catRevistas,
                    IdIndice = articulo.IdIndice,
                    NombreIndice = articulo.NombreIndice,
                    CatalogoIndice = catIndiceRevista,
                    Volumen = articulo.Volumen,
                    Numero = articulo.Numero,
                    Ano = articulo.Ano
                });
            }

            objetoVista.Patentes = new List<PatenteViewModel>();
            foreach (var patente in investigador.Patentes)
            {
                objetoVista.Patentes.Add(new PatenteViewModel()
                {
                    NombrePatente = patente.Nombre,
                    NumeroPatente = patente.NumPatente,
                    LugarInscripcion = patente.Lugar,
                    AnoInscripcion = patente.Ano
                });
            }

            objetoVista.Libros = new List<LibroViewModel>();
            foreach (var libro in investigador.Libros)
            {
                var catEditoriales = UipCatalogosGlobal.CatalogoEditorial;
                catEditoriales.ForEach(i => i.Selected = false);
                catEditoriales.First(i => i.Value == libro.IdEditorial.ToString()).Selected = true;

                var catTipoParticipacion = UipCatalogosGlobal.CatalogoParticipacionLibro;
                catTipoParticipacion.ForEach(i => i.Selected = false);
                catTipoParticipacion.First(i => i.Value == libro.IdTipoParticipacion.ToString()).Selected = true;

                objetoVista.Libros.Add(new LibroViewModel()
                {
                    Titulo = libro.Titulo,
                    EditorialSeleccionada = libro.NombreEditorial,
                    Editoriales = catEditoriales,
                    TipoParticipacionSeleccionada = libro.TipoParticipacion,
                    TiposParticipacion = catTipoParticipacion,
                    Ano = libro.Ano
                });
            }

            objetoVista.Licenciamientos = new List<LicenciamientoViewModel>();
            foreach (var licenciamiento in investigador.Licenciamientos)
            {
                objetoVista.Licenciamientos.Add(new LicenciamientoViewModel()
                {
                    ProductoLicenciado = licenciamiento.Producto,
                    PersonaConLicenciamiento = licenciamiento.LicenciadoA,
                    Ano = licenciamiento.Ano
                });
            }

            objetoVista.Software = new List<SoftwareViewModel>();
            foreach (var software in investigador.Software)
            {
                objetoVista.Software.Add(new SoftwareViewModel()
                {
                    Titulo = software.Titulo,
                    Plataforma = software.Plataforma,
                    Ano = software.Ano
                });
            }

            objetoVista.Ponencias = new List<PonenciaViewModel>();
            foreach (var ponencia in investigador.Ponencias)
            {
                var catPaisPonencia = UipCatalogosGlobal.CatalogoPais;
                catPaisPonencia.ForEach(i => i.Selected = false);
                catPaisPonencia.First(i => i.Value == ponencia.IdPais.ToString()).Selected = true;

                objetoVista.Ponencias.Add(new PonenciaViewModel()
                {
                    Titulo = ponencia.Titulo,
                    Seminario = ponencia.Seminario,
                    PaisSeleccionado = ponencia.NombrePais,
                    Paises = catPaisPonencia,
                    Ano = ponencia.Ano
                });
            }

            objetoVista.DatosPersonales = investigador.DatosPersonales;

            #endregion

            return View(objetoVista);
        }

        // GET: FichaInvestigador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FichaInvestigador/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FichaInvestigador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FichaInvestigador/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FichaInvestigador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FichaInvestigador/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
