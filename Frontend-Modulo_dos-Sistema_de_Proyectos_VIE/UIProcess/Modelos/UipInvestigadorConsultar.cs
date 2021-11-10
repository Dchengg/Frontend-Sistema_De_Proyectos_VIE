using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [DataContract]
    [Serializable]
    public class UipInvestigadorConsultar
    {
        [DataMember]
        public string NumeroIdentidad { get; set; } // Ok
        [DataMember]
        public byte[] Fotografia { get; set; } // Ok
        [DataMember]
        public string Nombre { get; set; } // Ok
        [DataMember]
        public string PrimerApellido { get; set; } // Ok
        [DataMember]
        public string SegundoApellido { get; set; } // Ok
        [DataMember]
        public System.DateTime FechaNacimiento { get; set; } // Ok
        [DataMember]
        public UipTipoIdentificacion TipoIdentificacion { get; set; }
        [DataMember]
        public UipPaisNacimiento PaisNacimiento { get; set; }
        [DataMember]
        public UipNacionalidad Nacionalidad { get; set; }
        [DataMember]
        public string Sexo { get; set; }
        [DataMember]
        public string ApartadoPostal { get; set; }
        [DataMember]
        public string Seudonimo { get; set; }
        [DataMember]
        public DateTime FechaDeIngresoInstitucion { get; set; }
        [DataMember]
        public UipSituacionLaboral SituacionLaboral { get; set; }
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
    }
}