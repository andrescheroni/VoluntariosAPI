using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoluntariosAPI.Models
{
	[Table("Oportunidad")]
	public class Oportunidad
	{
		[Key]
		public int OportunidadID { get; set; }
		public string Imagen { get; set; }
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
		public int? LocalidadID { get; set; }		
		public int? ProvinciaID { get; set; }		
		public int? PaisID { get; set; }
		[Required]
		public DateTime FechaPublicacion { get; set; }

		//Propiedades de navegación
		public Organizacion Organizacion { get; set; }
		public Entorno Entorno { get; set; }
		public Intensidad Intensidad { get; set; }
		public Social Social { get; set; }
		public Localidad Localidad { get; set; }
		public Provincia Provincia { get; set; }
		public Pais Pais { get; set; }
		public ICollection<Postulacion> Postulaciones { get; set; }
	}
}


