using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoluntariosAPI.DTOs
{
    public class LocalidadReadDto
    {
		public int LocalidadID { get; set; }		
		public int ProvinciaID { get; set; }		
		public string TipoLocalidad { get; set; }
	}
}