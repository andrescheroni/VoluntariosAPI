using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoluntariosAPI.DTOs
{
    public class VoluntarioReadDto
    {
		public int VolutnarioID { get; set; }
		public string Imagen { get; set; }		
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public DateTime FechaNacimiento { get; set; }
		public int DNI { get; set; }
		public string Direccion { get; set; }
		public int? LocalidadID { get; set; }
		public int? ProvinciaID { get; set; }
		public int? PaisID { get; set; }
		public string Mail { get; set; }
		public string Telefono { get; set; }
		public int EntornoID { get; set; }
		public int IntensidadID { get; set; }
		public int SocialID { get; set; }
		public bool Verificacion { get; set; }
		public DateTime FechaRegistro { get; set; }
		public DateTime? FechaVerificacion { get; set; }
	}
}