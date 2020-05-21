using System.ComponentModel.DataAnnotations;

namespace BlogCore.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [Display(Name = "Nombre Categoría")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Orden de visualización")]
        public int Orden { get; set; }
    }
}
