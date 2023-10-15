using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Transporte.Models
{
    [Table("Cursos")]
    public class Curso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="ID")]
        public int id { get; set; }
        [Required(ErrorMessage ="CAMPO NOME É OBRIGATORIO")]
        [StringLength(30)]
        [Display(Name ="NOME")]
        public string nome { get; set; }
    }
}
