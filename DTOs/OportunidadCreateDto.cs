using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoluntariosAPI.DTOs
{
    public class OportunidadCreateDto
    {
		public byte[] Imagen { get; set; }
		[Required]
		public int OrganizacionID { get; set; }		
		[Required]
		public string Actividad { get; set; }
		[Required]
		public string Descripcion { get; set; }
		[Required]
		public string Rol { get; set; }
		[Required]
		public int EntornoID { get; set; }		
		[Required]
		public int IntensidadID { get; set; }		
		[Required]
		public int SocialID { get; set; }		
		[Required]
		public DateTime FechaInicio { get; set; }
		[Required]
		public DateTime FechaFin { get; set; }
		[Required]
		public int LocalidadID { get; set; }		
		[Required]
		public int ProvinciaID { get; set; }		
		[Required]
		public int PaisID { get; set; }		
		[Required]
		public DateTime FechaPublicacion { get; set; }
		public bool Baja { get; set; }
	}
}