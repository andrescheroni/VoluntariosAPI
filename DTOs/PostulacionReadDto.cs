using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoluntariosAPI.DTOs
{
    public class PostulacionReadDto
    {
		public int PostulacionID { get; set; }		
		public int OportunidadID { get; set; }
		public int? VoluntarioID { get; set; }		
		public DateTime FechaPostulacion { get; set; }		
		public int EstadoPostulacionID { get; set; }
		public string Mensaje { get; set; }
	}
}