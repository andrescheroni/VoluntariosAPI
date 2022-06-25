using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoluntariosAPI.Models
{
	[Table("Localidad")]
	public class Localidad
	{
		[Key]
		public int LocalidadID { get; set; }
		[Required]
		public int ProvinciaID { get; set; }
		[Required]
		public string TipoLocalidad { get; set; }

		//Propiedades de navegación
		public Provincia Provincia { get; set; }
		public ICollection<Oportunidad> Oportunidades { get; set; }
		public ICollection<Voluntario> Voluntarios { get; set; }
		public ICollection<Organizacion> Organizaciones { get; set; }
	}
}


