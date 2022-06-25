using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoluntariosAPI.Models
{
    [Table("EstadoPostulacion")]
    public class EstadoPostulacion
    {
        [Key]
        public int EstadoPostulacionID { get; set; }
        [Required]
        public string Estado { get; set; }

        //Propiedades de navegación	
        public ICollection<Postulacion> Postulaciones { get; set; }
    }
}


