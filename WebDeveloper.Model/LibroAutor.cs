using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    public class LibroAutor
    {
        public int Id { get; set; }
        [Required]
        public int IdAutor { get; set; }
        [Required]
        public int IdLibro { get; set; }
        public string Tipo { get; set; }
    }
}
