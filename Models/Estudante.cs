using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Transporte.Models
{
    [Table("Estudantes")]
    public class Estudante
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display (Name="ID")]
        public int id { get; set; }

        [Display (Name = "NOME ESTUDANTE")]
        [Required (ErrorMessage ="NOME DO ESTUDANTE É OBRIGATORIO")]
        [StringLength(40)]
        public string nome { get; set; }


        [Display (Name ="TELEFONE")]
        [Required(ErrorMessage ="TELEFONE É OBRIGATORIO")]
        [StringLength(11)]
        public string telefone { get; set; }

   

    }
}
