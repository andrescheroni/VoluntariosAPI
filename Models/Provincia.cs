using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoluntariosAPI.Models
{
	[Table("Provincia")]
	public class Provincia
	{
		[Key]
		public int ProvinciaID { get; set; }
		[Required]
		public int PaisID { get; set; }
		[Required]
		public string NombreProvincia { get; set; }

		//Propiedades de navegación
		public Pais Pais { get; set; }
		public ICollection<Oportunidad> Oportunidades { get; set; }
		public ICollection<Voluntario> Voluntarios { get; set; }
		public ICollection<Organizacion> Organizaciones { get; set; }
		public ICollection<Localidad> Localidades { get; set; }

	}
}


