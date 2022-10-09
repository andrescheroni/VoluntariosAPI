using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoluntariosAPI.Models
{
	[Table("Postulacion")]
	public class Postulacion
	{
		[Key]
		public int PostulacionID { get; set; }
		[Required]
		public int OportunidadID { get; set; }		
		public int? VoluntarioID { get; set; }
		[Required]
		public DateTime FechaPostulacion { get; set; }
		[Required]
		public int EstadopostulacionID { get; set; }
		public string Mensaje { get; set; }

		//Propiedades de navegación		
		public Oportunidad Oportunidad { get; set; }
		public Voluntario Voluntario { get; set; }
		public Estadopostulacion Estado { get; set; }
	}
}


