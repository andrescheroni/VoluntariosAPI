using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VoluntariosAPI.DTOs
{
    public class OrganizacionUpdateDto
    {        
        public byte[] Imagen { get; set; }
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
        public bool Verificacion { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaVerificacion { get; set; }
    }
}