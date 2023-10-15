using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Transporte.Models
{
    [Table("Agendamentos")]
    public class Agendamento
    {
        [Key]
        [Display(Name ="Id")]
        public int id { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage ="DATA OBRIGATORIA")]
        public DateTime data { get; set; }

        [DataType(DataType.Time)]
        [Required(ErrorMessage = "HORARIO OBRIGATORIO")]
        public TimeSpan horario { get; set; }

        [Display(Name = "Estudante")]
        public int IdEstudante { get; set; }
        [ForeignKey("IdEstudante")]
        public Estudante Estudante { get; set; }

        [Display(Name = "Veiculo")]
        public int IdVeiculo { get; set; }
        [ForeignKey("IdVeiculo")]
        public Veiculo Veiculo { get; set; }







      
    }
}
