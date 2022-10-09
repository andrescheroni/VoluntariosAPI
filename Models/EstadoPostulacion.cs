using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoluntariosAPI.Models
{
    [Table("Estadopostulacion")]
    public class Estadopostulacion
    {
        [Key]
        public int EstadopostulacionID { get; set; }
        [Required]
        public string Estado { get; set; }

        //Propiedades de navegación	
        public ICollection<Postulacion> Postulaciones { get; set; }
    }
}


