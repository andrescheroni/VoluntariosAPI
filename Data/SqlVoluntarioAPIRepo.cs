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
            return _context.Organizaciones.ToList();
        }

        public Organizacion GetOrganizacionById(int id)
        {
            return _context.Organizaciones.FirstOrDefault(p => p.OrganizacionID == id);
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
            return _context.Voluntarios.ToList();
        }

        public Voluntario GetVoluntarioById(int id)
        {
            return _context.Voluntarios.FirstOrDefault(p => p.VolutnarioID == id);
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
            return _context.Oportunidades.ToList();
        }

        public Oportunidad GetOportunidadById(int id)
        {
            return _context.Oportunidades.FirstOrDefault(p => p.OportunidadID == id);
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
            return _context.Postulaciones.ToList();
        }

        public Postulacion GetPostulacionById(int id)
        {
            return _context.Postulaciones.FirstOrDefault(p => p.PostulacionID == id);
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

        //EstadoPostulacion

        public IEnumerable<EstadoPostulacion> GetAllEstadoPostulaciones()
        {
            return _context.EstadoPostulaciones.ToList();
        }

        public EstadoPostulacion GetEstadoPostulacionById(int id)
        {
            return _context.EstadoPostulaciones.FirstOrDefault(p => p.EstadoPostulacionID == id);
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
