using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoluntariosAPI.Models;

namespace VoluntariosAPI.Data
{
    public class VoluntariosAPIContext : DbContext
    {
        public VoluntariosAPIContext(DbContextOptions<VoluntariosAPIContext> opt) : base(opt)
        {

        }

        public DbSet<Entorno> Entornos { get; set; }
        public DbSet<Estadopostulacion> Estadopostulaciones { get; set; }
        public DbSet<Intensidad> Intensidades { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Oportunidad> Oportunidades { get; set; }
        public DbSet<Organizacion> Organizaciones { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Postulacion> Postulaciones { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Social> Sociales { get; set; }
        public DbSet<Voluntario> Voluntarios { get; set; }

    }
}
