using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Transporte.Models
{
    [Table("Cursos")]
    public class Curso
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(30)]
        public string nome { get; set; }
    }
}
