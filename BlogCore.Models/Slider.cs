using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlogCore.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]        
        public string Nombre { get; set; }        
        
        public bool Estado { get; set; }
        
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imágen")]
        public string UrlImagen { get; set; }        
    }
}
