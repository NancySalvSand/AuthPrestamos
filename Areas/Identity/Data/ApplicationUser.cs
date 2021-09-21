using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthPrestamos.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class

    public class ApplicationUser : IdentityUser
    {
        //campos adicionales 

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string NombreUser { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string ApellidosUser { get; set; }

        [PersonalData]
        [Column(TypeName = "date")]
        public DateTime FechaNacimientoUser { get; set; }

        [PersonalData]
        [Display(Name = "Edad")]
        public int Edad
        {
            get
            {
                int edad = DateTime.Today.Year - FechaNacimientoUser.Year;

                //si el mes es menor restamos un año directamente
                if (DateTime.Today.Month < FechaNacimientoUser.Month)
                {
                    --edad;
                }
                //sino preguntamos si estamos en el mismo mes, si es el mismo preguntamos si el dia de hoy es menor al de la fecha de nacimiento
                else if (DateTime.Today.Month == FechaNacimientoUser.Month && DateTime.Today.Day < FechaNacimientoUser.Day)
                {
                    --edad;
                }

                return edad;
            }


        }
    }
}


