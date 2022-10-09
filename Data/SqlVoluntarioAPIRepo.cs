using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoluntariosAPI.Models;

namespace VoluntariosAPI.Data
{
    public class SqlVoluntarioAPIRepo : IVoluntarioAPIRepo
    {
        private readonly VoluntariosAPIContext _context;

        public SqlVoluntarioAPIRepo(VoluntariosAPIContext context)
        {
            _context = context;
        }

        public bool SaveChanges()
        {            
            return (_context.SaveChanges() >= 0);
        }
                
        //Organizacion

        public IEnumerable<Organizacion> GetAllOrganizaciones()
        {
            return _context.Organizaciones
                .Include(x => x.Localidad)
                .Include(x => x.Provincia)
                .Include(x => x.Pais)
                .ToList();
        }

        public Organizacion GetOrganizacionById(int id)
        {            
            var organizacionItem = _context.Organizaciones
                .Where(x => x.OrganizacionID == id)
                .Include(x => x.Localidad)
                .Include(x => x.Provincia)
                .Include(x => x.Pais)
                .SingleOrDefault();

            return organizacionItem;
        }
        
        public void CreateOrganizacion(Organizacion item)
        {
            if(item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _context.Organizaciones.Add(item);
        }

        public void UpdateOrganizacion(Organizacion item)
        {
            //No es necesario
        }

        public void DeleteOrganizacion(Organizacion item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _context.Organizaciones.Remove(item);
        }

        //Voluntario

        public IEnumerable<Voluntario> GetAllVoluntarios()
        {
            return _context.Voluntarios
                .Include(x => x.Localidad)
                .Include(x => x.Provincia)
                .Include(x => x.Pais)
                .Include(x => x.Entorno)
                .Include(x => x.Intensidad)
                .Include(x => x.Social)
                .ToList();
        }

        public Voluntario GetVoluntarioById(int id)
        {
            var voluntarioItem = _context.Voluntarios
                .Where(x => x.VolutnarioID == id)
                .Include(x => x.Localidad)
                .Include(x => x.Provincia)
                .Include(x => x.Pais)
                .Include(x => x.Entorno)
                .Include(x => x.Intensidad)
                .Include(x => x.Social)
                .SingleOrDefault();

            return voluntarioItem;
        }

        public void CreateVoluntario(Voluntario item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _context.Voluntarios.Add(item);
        }

        public void UpdateVoluntario(Voluntario item)
        {
            //No es necesario
        }

        public void DeleteVoluntario(Voluntario item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _context.Voluntarios.Remove(item);
        }

        //Oportunidad

        public IEnumerable<Oportunidad> GetAllOportunidades()
        {
            return _context.Oportunidades
                .Include(x => x.Localidad)
                .Include(x => x.Provincia)
                .Include(x => x.Pais)
                .Include(x => x.Entorno)
                .Include(x => x.Intensidad)
                .Include(x => x.Social)
                .Include(x => x.Organizacion)
                .ToList();
        }

        public IEnumerable<Oportunidad> GetOportunidadesByOrganizacionId(int id)
        {
            return _context.Oportunidades.Where(p => p.OrganizacionID == id).ToList();
        }

        public Oportunidad GetOportunidadById(int id)
        {
            var oportunidadItem = _context.Oportunidades
                .Where(x => x.OportunidadID == id)
                .Include(x => x.Localidad)
                .Include(x => x.Provincia)
                .Include(x => x.Pais)
                .Include(x => x.Entorno)
                .Include(x => x.Intensidad)
                .Include(x => x.Social)
                .Include(x => x.Organizacion)                
                .SingleOrDefault();

            return oportunidadItem;
        }

        public void CreateOportunidad(Oportunidad item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _context.Oportunidades.Add(item);
        }

        public void UpdateOportunidad(Oportunidad item)
        {
            //No es necesario
        }

        public void DeleteOportunidad(Oportunidad item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _context.Oportunidades.Remove(item);
        }

        //Postulacion
        
        public IEnumerable<Postulacion> GetAllPostulaciones()
        {
            return _context.Postulaciones
                .Include(x => x.Oportunidad)
                .Include(x => x.Voluntario)
                .Include(x => x.Estado)
                .ToList();
        }

        public IEnumerable<Postulacion> GetPostulacionesByOportunidadId(int id)
        {
            return _context.Postulaciones.Where(p => p.OportunidadID == id)
                .Include(x => x.Oportunidad)
                .Include(x => x.Voluntario)
                .Include(x => x.Estado)
                .ToList();
        }

        public IEnumerable<Postulacion> GetPostulacionesByVoluntarioId(int id)
        {
            return _context.Postulaciones.Where(p => p.VoluntarioID == id)
                .Include(x => x.Oportunidad)
                .Include(x => x.Voluntario)
                .Include(x => x.Estado)
                .ToList();
        }

        public Postulacion GetPostulacionById(int id)
        {            
            var postulacionItem = _context.Postulaciones
                .Where(x => x.PostulacionID == id)
                .Include(x => x.Oportunidad)
                .Include(x => x.Voluntario)
                .Include(x => x.Estado)
                .SingleOrDefault();

            return postulacionItem;
        }

        public void CreatePostulacion(Postulacion item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _context.Postulaciones.Add(item);
        }

        public void UpdatePostulacion(Postulacion item)
        {
            //No es necesario
        }

        public void DeletePostulacion(Postulacion item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _context.Postulaciones.Remove(item);
        }

        //Entorno

        public IEnumerable<Entorno> GetAllEntornos()
        {
            return _context.Entornos.ToList();
        }

        public Entorno GetEntornoById(int id)
        {
            return _context.Entornos.FirstOrDefault(p => p.EntornoID == id);
        }

        //Estadopostulacion

        public IEnumerable<Estadopostulacion> GetAllEstadopostulaciones()
        {
            return _context.Estadopostulaciones.ToList();
        }

        public Estadopostulacion GetEstadopostulacionById(int id)
        {
            return _context.Estadopostulaciones.FirstOrDefault(p => p.EstadopostulacionID == id);
        }

        //Intensidad
        public IEnumerable<Intensidad> GetAllIntensidades()
        {
            return _context.Intensidades.ToList();
        }

        public Intensidad GetIntensidadById(int id)
        {
            return _context.Intensidades.FirstOrDefault(p => p.IntensidadID == id);
        }
                
        //Localidad

        public IEnumerable<Localidad> GetAllLocalidades()
        {
            return _context.Localidades.ToList();
        }
        
        public IEnumerable<Localidad> GetLocalidadesByProvinciaId(int id)
        {
            return _context.Localidades.Where(p => p.ProvinciaID == id).ToList();
        }

        public Localidad GetLocalidadById(int id)
        {
            return _context.Localidades.FirstOrDefault(p => p.LocalidadID == id);
        }

        //Pais

        public IEnumerable<Pais> GetAllPaises()
        {
            return _context.Paises.ToList();
        }

        public Pais GetPaisById(int id)
        {
            return _context.Paises.FirstOrDefault(p => p.PaisID == id);
        }

        //Provincia

        public IEnumerable<Provincia> GetAllProvincias()
        {
            return _context.Provincias.ToList();
        }

        public IEnumerable<Provincia> GetProvinciasByPaisId(int id)
        {
            return _context.Provincias.Where(p => p.PaisID == id).ToList();
        }

        public Provincia GetProvinciaById(int id)
        {
            return _context.Provincias.FirstOrDefault(p => p.ProvinciaID == id);
        }

        //Social
        public IEnumerable<Social> GetAllSociales()
        {
            return _context.Sociales.ToList();
        }

        public Social GetSocialById(int id)
        {
            return _context.Sociales.FirstOrDefault(p => p.SocialID == id);
        }

    }
}
