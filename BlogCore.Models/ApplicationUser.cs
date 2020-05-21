using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogCore.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string Nombre { get; set; }
        
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        public string Ciudad { get; set; }

        [Display(Name = "País")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string Pais { get; set; }
    }
}
