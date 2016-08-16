using System;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    public class Libro
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Titulo { get; set; }
        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }
        [Required]        
        [Display(Name = "Código de la publicación")]
        public int Id_Publicacion { get; set; }
        [Required]
        public decimal Precio { get; set; }
        public string Avance { get; set; }
        public decimal Regalias { get; set; }
        [Required]
        public decimal Ventas { get; set; }
        public string Notas { get; set; }
        [Display(Name = "Fecha de la publicación")]
        public DateTime Fecha_Publicacion { get; set; }
    }
}
