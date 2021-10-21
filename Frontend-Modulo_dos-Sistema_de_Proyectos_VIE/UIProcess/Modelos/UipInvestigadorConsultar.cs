using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace UIProcess.Modelos
{
    [DataContract]
    [Serializable]
    public class UipInvestigadorConsultar
    {
        [DataMember]
        public string NumeroIdentidad { get; set; }
        [DataMember]
        public byte[] Fotografia { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string PrimerApellido { get; set; }
        [DataMember]
        public string SegundoApellido { get; set; }
        [DataMember]
        public System.DateTime FechaNacimiento { get; set; }
        [DataMember]
        public int IdTipoIdentificacion { get; set; }
        [DataMember]
        public string TipoIdentificacion { get; set; }
        [DataMember]
        public int IdPaisNacimiento { get; set; }
        [DataMember]
        public string PaisNacimiento { get; set; }
        [DataMember]
        public int IdNacionalidad { get; set; }
        [DataMember]
        public string Nacionalidad { get; set; }
        [DataMember]
        public string Sexo { get; set; }
        [DataMember]
        public string ApartadoPostal { get; set; }
        [DataMember]
        public string Seudonimo { get; set; }
        [DataMember]
        public DateTime FechaDeIngresoInstitucion { get; set; }
        [DataMember]
        public int IdSituacionLaboral { get; set; }
        [DataMember]
        public string SituacionLaboral { get; set; }
        [DataMember]
        public List<UipTelefono> Telefonos { get; set; }
        [DataMember]
        public List<UipCorreo> Correos { get; set; }
        [DataMember]
        public int PorcentajeNombramiento { get; set; }
        [DataMember]
        public bool DatosPersonales { get; set; }
        [DataMember]
        public List<UipEstudioRealizado> EstudiosRealizados { get; set; }
        [DataMember]
        public List<UipIdioma> Idiomas { get; set; }
        [DataMember]
        public List<UipExperienciaAcademica> ExperienciasAcademicas { get; set; }
        [DataMember]
        public List<UipParticipacion> Participaciones { get; set; }
        [DataMember]
        public List<UipPremio> Premios { get; set; }
        [DataMember]
        public List<UipArticulo> Articulos { get; set; }
        [DataMember]
        public List<UipPatente> Patentes { get; set; }
        [DataMember]
        public List<UipLibro> Libros { get; set; }
        [DataMember]
        public List<UipPonencia> Ponencias { get; set; }
        [DataMember]
        public List<UipSoftware> Software { get; set; }
        [DataMember]
        public List<UipLicenciamiento> Licenciamientos { get; set; }
        [DataMember]
        public List<UipCategoriaAcademica> CategoriasAcademicas { get; set; }
        [DataMember]
        public List<UipUnidadAcademica> UnidadesAcademicas { get; set; }
        [DataMember]
        public List<UipSubdisciplina> SubdisciplinasCientificas { get; set; }
        [DataMember]
        public List<UipPerfilAcademico> PerfilesAcademicos { get; set; }

        public UipInvestigadorConsultar(string numeroIdentidad, byte[] fotografia, string nombre, string primerApellido,
                                      string segundoApellido, DateTime fechaNacimiento, int idTipoIdentificacion,
                                      string tipoIdentificacion, int idPaisNacimiento, string paisNacimiento, int idNacionalidad,
                                      string nacionalidad, string apartadoPostal, string seudonimo, DateTime fechaDeIngresoInstitucion,
                                      int idSituacionLaboral, string situacionLaboral, int porcentajeNombramiento, bool datosPersonales,
                                      List<UipEstudioRealizado> estudiosRealizados, List<UipIdioma> idiomas, List<UipExperienciaAcademica> experienciasAcademicas,
                                      List<UipParticipacion> participaciones, List<UipPremio> premios,
                                      List<UipArticulo> articulos, List<UipPatente> patentes, List<UipLibro> libros, List<UipPonencia> ponencias, List<UipSoftware> software,
                                      List<UipLicenciamiento> licenciamientos, List<UipCategoriaAcademica> categoriasAcademicas,
                                      List<UipUnidadAcademica> unidadesAcademicas, List<UipSubdisciplina> subdisciplinasCientificas,
                                      List<UipPerfilAcademico> perfilesAcademicos)
        {
            NumeroIdentidad = numeroIdentidad;
            Fotografia = fotografia;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            FechaNacimiento = fechaNacimiento;
            IdTipoIdentificacion = idTipoIdentificacion;
            TipoIdentificacion = tipoIdentificacion;
            IdPaisNacimiento = idPaisNacimiento;
            PaisNacimiento = paisNacimiento;
            IdNacionalidad = idNacionalidad;
            Nacionalidad = nacionalidad;
            ApartadoPostal = apartadoPostal;
            Seudonimo = seudonimo;
            FechaDeIngresoInstitucion = fechaDeIngresoInstitucion;
            IdSituacionLaboral = idSituacionLaboral;
            SituacionLaboral = situacionLaboral;
            PorcentajeNombramiento = porcentajeNombramiento;
            DatosPersonales = datosPersonales;
            EstudiosRealizados = estudiosRealizados;
            Idiomas = idiomas;
            ExperienciasAcademicas = experienciasAcademicas;
            Participaciones = participaciones;
            Premios = premios;
            Articulos = articulos;
            Patentes = patentes;
            Libros = libros;
            Ponencias = ponencias;
            Software = software;
            Licenciamientos = licenciamientos;
            CategoriasAcademicas = categoriasAcademicas;
            UnidadesAcademicas = unidadesAcademicas;
            SubdisciplinasCientificas = subdisciplinasCientificas;
            PerfilesAcademicos = perfilesAcademicos;
        }
    }
}