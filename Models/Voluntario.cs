using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoluntariosAPI.Models
{
	[Table("Voluntario")]
	public class Voluntario
	{
		[Key]
		public int VolutnarioID { get; set; }
		public string Imagen { get; set; }
		[Required]
		public string Nombre { get; set; }
		[Required]
		public string Apellido { get; set; }
		[Required]
		public DateTime FechaNacimiento { get; set; }
		[Required]
		public int DNI { get; set; }
		[Required]
		public string Direccion { get; set; }
		public int? LocalidadID { get; set; }		
		public int? ProvinciaID { get; set; }		
		public int? PaisID { get; set; }
		[Required]
		public string Mail { get; set; }
		[Required]
		public string PasswordHash { get; set; }
		[Required]
		public string Telefono { get; set; }
		[Required]
		public int EntornoID { get; set; }
		[Required]
		public int IntensidadID { get; set; }
		[Required]
		public int SocialID { get; set; }
		[Required]
		public bool Verificacion { get; set; }
		[Required]
		public DateTime FechaRegistro { get; set; }
		public DateTime? FechaVerificacion { get; set; }

		//Propiedades de navegación
		public Entorno Entorno { get; set; }
		public Intensidad Intensidad { get; set; }
		public Social Social { get; set; }
		public Localidad Localidad { get; set; }
		public Provincia Provincia { get; set; }
		public Pais Pais { get; set; }
		public ICollection<Postulacion> Postulaciones { get; set; }
	}
}
