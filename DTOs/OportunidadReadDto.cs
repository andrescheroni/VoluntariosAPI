using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoluntariosAPI.DTOs
{
    public class OportunidadReadDto
    {
		public int OportunidadID { get; set; }
		public string Imagen { get; set; }
		public int OrganizacionID { get; set; }
		public string Actividad { get; set; }
		public string Descripcion { get; set; }
		public string Rol { get; set; }
		public int EntornoID { get; set; }
		public int IntensidadID { get; set; }
		public int SocialID { get; set; }
		public DateTime FechaInicio { get; set; }
		public DateTime FechaFin { get; set; }
		public int? LocalidadID { get; set; }
		public int? ProvinciaID { get; set; }
		public int? PaisID { get; set; }
		public DateTime FechaPublicacion { get; set; }
	}
}