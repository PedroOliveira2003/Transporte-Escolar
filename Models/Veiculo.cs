using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Transporte.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(30)]
        public string nomeveiculo { get; set; }
        [Required]
        public string placa { get; set; }

    }
}
