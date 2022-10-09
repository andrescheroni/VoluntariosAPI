using System.Collections.Generic;
using VoluntariosAPI.Models;

namespace VoluntariosAPI.Data
{
    public class MockVoluntarioAPIRepo
    //public class MockVoluntarioAPIRepo : IVoluntarioAPIRepo
    {
        public Organizacion GetOrganizacionById(int id)
        {
            return new Organizacion {
                OrganizacionID = 0,
                //Imagen = null,
                RazonSocial = "Greenpeace",
                Descripcion = "Salvemos al mundo",
                CUIT = "33-54644123-8",
                NombreResponsable = "Juan Carlos",
                ApellidoResponsable = "Green",
                DNIResponsable = "20.445.121",
                Direccion = "Ballenas 123",
                LocalidadID = 1,
                ProvinciaID = 1,
                PaisID = 1,
                Mail = "greenpeace@greenpeace.com.ar",
                PasswordHash = "fuHLhHJL4k3h",
                Telefono = "054-9-11-4546-5464",
                Verificacion = false,
                FechaRegistro = new System.DateTime(2022, 4, 1),
                FechaVerificacion = new System.DateTime(2022, 4, 1)
            };
        }

        public IEnumerable<Organizacion> GetAllOrganizaciones()
        {
            var Organizaciones = new List<Organizacion>
            {
                new Organizacion
                {
                    OrganizacionID = 1,
                    //Imagen = null,
                    RazonSocial = "Greenpeace",
                    Descripcion = "Salvemos al mundo",
                    CUIT = "33-54644123-8",
                    NombreResponsable = "Juan Carlos",
                    ApellidoResponsable = "Green",
                    DNIResponsable = "20.445.121",
                    Direccion = "Ballenas 123",
                    LocalidadID = 1,
                    ProvinciaID = 1,
                    PaisID = 1,
                    Mail = "greenpeace@greenpeace.com.ar",
                    PasswordHash = "fuHLhHJL4k3h",
                    Telefono = "054-9-11-4546-5464",
                    Verificacion = false,
                    FechaRegistro = new System.DateTime(2022, 4, 1),
                    FechaVerificacion = new System.DateTime(2022, 4, 1)
                },
                new Organizacion
                {
                    OrganizacionID = 2,
                    //Imagen = null,
                    RazonSocial = "Fundacion SI",
                    Descripcion = "Ayudemos a la gente",
                    CUIT = "30-44213543-1",
                    NombreResponsable = "Juan Alberto",
                    ApellidoResponsable = "Afirmativo",
                    DNIResponsable = "21.445.132",
                    Direccion = "Fundacion 324",
                    LocalidadID = 2,
                    ProvinciaID = 2,
                    PaisID = 1,
                    Mail = "fundacionsi@fundacionsi.com.ar",
                    PasswordHash = "fuHLhHJL4446fads",
                    Telefono = "054-9-11-4454-3185",
                    Verificacion = true,
                    FechaRegistro = new System.DateTime(2022, 4, 5),
                    FechaVerificacion = new System.DateTime(2022, 4, 9)
                },
                new Organizacion
                {
                    OrganizacionID = 3,
                    //Imagen = null,
                    RazonSocial = "Comedor Las Sonrisas",
                    Descripcion = "Demos de comer",
                    CUIT = "31-11213154-5",
                    NombreResponsable = "Juana",
                    ApellidoResponsable = "Azurduy",
                    DNIResponsable = "21.442.745",
                    Direccion = "Proceres 875",
                    LocalidadID = 3,
                    ProvinciaID = 2,
                    PaisID = 1,
                    Mail = "comedor@lassonrisas.com.ar",
                    PasswordHash = "fgd54ñjJKLj54",
                    Telefono = "054-9-11-4459-7542",
                    Verificacion = false,
                    FechaRegistro = new System.DateTime(2022, 4, 15),
                    FechaVerificacion = new System.DateTime(2022, 4, 15)
                }
            };
            return Organizaciones;
        }

        public IEnumerable<Voluntario> GetAllVoluntarios()
        {
            throw new System.NotImplementedException();
        }

        public Voluntario GetVoluntarioById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}