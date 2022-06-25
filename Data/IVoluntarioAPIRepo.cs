using System.Collections.Generic;
using VoluntariosAPI.Models;

namespace VoluntariosAPI.Data
{
    public interface IVoluntarioAPIRepo
    {
        bool SaveChanges();
        
        //Organizacion
        IEnumerable<Organizacion> GetAllOrganizaciones();
        Organizacion GetOrganizacionById(int id);
        void CreateOrganizacion(Organizacion item);
        void UpdateOrganizacion(Organizacion item);
        void DeleteOrganizacion(Organizacion item);

        //Voluntario
        IEnumerable<Voluntario> GetAllVoluntarios();
        Voluntario GetVoluntarioById(int id);
        void CreateVoluntario(Voluntario item);
        void UpdateVoluntario(Voluntario item);
        void DeleteVoluntario(Voluntario item);

        //Oportunidad
        IEnumerable<Oportunidad> GetAllOportunidades();
        Oportunidad GetOportunidadById(int id);
        void CreateOportunidad(Oportunidad item);
        void UpdateOportunidad(Oportunidad item);
        void DeleteOportunidad(Oportunidad item);

        //Postulacion
        IEnumerable<Postulacion> GetAllPostulaciones();
        Postulacion GetPostulacionById(int id);
        void CreatePostulacion(Postulacion item);
        void UpdatePostulacion(Postulacion item);
        void DeletePostulacion(Postulacion item);

        //Entorno
        IEnumerable<Entorno> GetAllEntornos();
        Entorno GetEntornoById(int id);

        //EstadoPostulacion
        IEnumerable<EstadoPostulacion> GetAllEstadoPostulaciones();
        EstadoPostulacion GetEstadoPostulacionById(int id);

        //Intensidad
        IEnumerable<Intensidad> GetAllIntensidades();
        Intensidad GetIntensidadById(int id);

        //Localidad
        IEnumerable<Localidad> GetAllLocalidades();
        Localidad GetLocalidadById(int id);

        //Pais
        IEnumerable<Pais> GetAllPaises();
        Pais GetPaisById(int id);

        //Provincia
        IEnumerable<Provincia> GetAllProvincias();
        Provincia GetProvinciaById(int id);

        //Social
        IEnumerable<Social> GetAllSociales();
        Social GetSocialById(int id);
    }
}