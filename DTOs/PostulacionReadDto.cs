using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoluntariosAPI.DTOs
{
    public class PostulacionReadDto
    {
		public int PostulacionID { get; set; }		
		public int OportunidadID { get; set; }
		public string OportunidadActividad { get; set; }		
		public string OportunidadDescripcion { get; set; }
		public string OportunidadRol { get; set; }
		public int OportunidadEntornoID { get; set; }
		public string OportunidadEntornoTipoEntorno { get; set; }
		public int OportunidadIntensidadID { get; set; }
		public string OportunidadIntensidadTipoIntensidad { get; set; }
		public int OportunidadSocialID { get; set; }
		public string OportunidadSocialTipoSocial { get; set; }
		public DateTime OportunidadFechaInicio { get; set; }
		public DateTime OportunidadFechaFin { get; set; }
		public int OportunidadLocalidadID { get; set; }
		public string OportunidadLocalidadTipoLocalidad { get; set; }
		public int OportunidadProvinciaID { get; set; }
		public string OportunidadProvinciaNombreProvincia { get; set; }
		public int OportunidadPaisID { get; set; }
		public string OportunidadPaisNombrePais { get; set; }
		public bool OportunidadBaja { get; set; }
		public int VoluntarioID { get; set; }
		public string VoluntarioNombre { get; set; }
		public string VoluntarioApellido { get; set; }
		public byte[] VoluntarioImagen { get; set; }
		public int VoluntarioLocalidadID { get; set; }
		public string VoluntarioLocalidadTipoLocalidad { get; set; }
		public int VoluntarioProvinciaID { get; set; }
		public string VoluntarioProvinciaNombreProvincia { get; set; }
		public int VoluntarioPaisID { get; set; }
		public string VoluntarioPaisNombrePais { get; set; }
		public DateTime VoluntarioFechaNacimiento { get; set; }
		public string VoluntarioMail { get; set; }
		public string VoluntarioTelefono { get; set; }
		public bool VoluntarioVerificado { get; set; }
		public DateTime FechaPostulacion { get; set; }		
		public int EstadopostulacionID { get; set; }
		public string EstadopostulacionEstado { get; set; }
		public string Mensaje { get; set; }
	}
}