using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    public class Autor
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }
        [Required]
        [StringLength(9)]
        public string Telefonos { get; set; }
        [Required]
        [StringLength(50)]
        public string Ciudad { get; set; }
        [Required]
        [StringLength(50)]
        public string Estado { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Código Ciudad")]
        public string Codigo_Cuidad { get; set; }
        public int Sexo { get; set; }
        public decimal Salario { get; set; }
        public string Tema { get; set; }
    }
}
