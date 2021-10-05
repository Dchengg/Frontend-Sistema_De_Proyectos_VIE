using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace UIProcess.Modelos
{
    [DataContract]
    [Serializable]
    public class InvestigadorConsultar
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
        public int PorcentajeNombramiento { get; set; }
        [DataMember]
        public bool DatosPersonales { get; set; }
        [DataMember]
        public List<oEstudioRealizado> EstudiosRealizados { get; set; }
        [DataMember]
        public List<oIdioma> Idiomas { get; set; }
        [DataMember]
        public List<oExperienciaAcademica> ExperienciaAcademicas { get; set; }
        [DataMember]
        public List<oArticulo> Articulos { get; set; }
        [DataMember]
        public List<oPatente> Patentes { get; set; }
        [DataMember]
        public List<oLibro> Libros { get; set; }
        [DataMember]
        public List<oPonencia> Ponencias { get; set; }
        [DataMember]
        public List<oSoftware> Software { get; set; }
        [DataMember]
        public List<oLicenciamiento> Licenciamientos { get; set; }
        [DataMember]
        public List<oCategoriaAcademica> CategoriasAcademicas { get; set; }
        [DataMember]
        public List<oExperienciaAcademica> ExperienciasAcademicas { get; set; }
        [DataMember]
        public List<oUnidadAcademica> UnidadesAcademicas { get; set; }
        [DataMember]
        public List<oSubdisciplina> SubdisciplinasCientificas { get; set; }

        public InvestigadorConsultar(string numeroIdentidad, byte[] fotografia, string nombre, string primerApellido,
                                      string segundoApellido, DateTime fechaNacimiento, int idTipoIdentificacion,
                                      string tipoIdentificacion, int idPaisNacimiento, string paisNacimiento, int idNacionalidad,
                                      string nacionalidad, string apartadoPostal, string seudonimo, DateTime fechaDeIngresoInstitucion,
                                      int idSituacionLaboral, string situacionLaboral, int porcentajeNombramiento, bool datosPersonales,
                                      List<oEstudioRealizado> estudiosRealizados, List<oIdioma> idiomas, List<oExperienciaAcademica> experienciaAcademicas,
                                      List<oArticulo> articulos, List<oPatente> patentes, List<oLibro> libros, List<oPonencia> ponencias, List<oSoftware> software,
                                      List<oLicenciamiento> licenciamientos, List<oCategoriaAcademica> categoriasAcademicas, List<oExperienciaAcademica> experienciasAcademicas,
                                      List<oUnidadAcademica> unidadesAcademicas, List<oSubdisciplina> subdisciplinasCientificas)
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
            ExperienciaAcademicas = experienciaAcademicas;
            Articulos = articulos;
            Patentes = patentes;
            Libros = libros;
            Ponencias = ponencias;
            Software = software;
            Licenciamientos = licenciamientos;
            CategoriasAcademicas = categoriasAcademicas;
            ExperienciasAcademicas = experienciasAcademicas;
            UnidadesAcademicas = unidadesAcademicas;
            SubdisciplinasCientificas = subdisciplinasCientificas;
        }
    }
}