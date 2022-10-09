using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoluntariosAPI.DTOs
{
    public class VoluntarioCreateDto
    {
		public byte[] Imagen { get; set; }
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
		[Required]
		public int LocalidadID { get; set; }
		[Required]
		public int ProvinciaID { get; set; }
		[Required]
		public int PaisID { get; set; }
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
	}
}