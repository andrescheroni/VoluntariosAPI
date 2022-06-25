using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoluntariosAPI.Models
{
    [Table("Organizacion")]
    public class Organizacion
    {
        [Key]
        public int OrganizacionID { get; set; }
        public string Imagen { get; set; }
        [Required]
        public string RazonSocial { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(11)]
        public string CUIT { get; set; }
        [Required]
        public string NombreResponsable { get; set; }
        [Required]
        public string ApellidoResponsable { get; set; }
        [Required]
        [StringLength(9)]
        public string DNIResponsable { get; set; }
        [Required]
        public string Direccion { get; set; }
        public int? LocalidadID { get; set; }        
        public int? ProvinciaID { get; set; }        
        public int? PaisID { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public bool Verificacion { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaVerificacion { get; set; }

        //Propiedades de navegación
        public Localidad Localidad { get; set; }
        public Provincia Provincia { get; set; }
        public Pais Pais { get; set; }
        public ICollection<Oportunidad> Oportunidades { get; set; }
    }
}