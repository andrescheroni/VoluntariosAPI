using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoluntariosAPI.Models
{
	[Table("Pais")]
	public class Pais
	{
		[Key]
		public int PaisID { get; set; }
		[Required]
		public string NombrePais { get; set; }

		//Propiedades de navegación
		public ICollection<Oportunidad> Oportunidades { get; set; }
		public ICollection<Voluntario> Voluntarios { get; set; }
		public ICollection<Organizacion> Organizaciones { get; set; }
		public ICollection<Provincia> Provincias { get; set; }
	}
}


