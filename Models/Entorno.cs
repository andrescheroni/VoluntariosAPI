using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoluntariosAPI.Models
{
	[Table("Entorno")]
	public class Entorno
	{
		[Key]
		public int EntornoID { get; set; }
		[Required]
		public string TipoEntorno { get; set; }

		//Propiedades de navegación
		public ICollection<Oportunidad> Oportunidades { get; set; }
		public ICollection<Voluntario> Voluntarios { get; set; }
	}
}


