using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoluntariosAPI.DTOs
{
    public class PostulacionCreateDto
    {
		[Required]
		public int OportunidadID { get; set; }
		[Required]
		public int? VoluntarioID { get; set; }
		[Required]
		public DateTime FechaPostulacion { get; set; }
		[Required]
		public int EstadoPostulacionID { get; set; }
		public string Mensaje { get; set; }
	}
}