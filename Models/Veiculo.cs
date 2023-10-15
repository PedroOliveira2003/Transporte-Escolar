﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Transporte.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage ="NOME DO VEICULO É OBRIGATORIO")]
        [StringLength(30)]
        [Display(Name = "NOME VEICULO")]
        public string nomeveiculo { get; set; }


        [Required(ErrorMessage ="PLACA DO VEICULO É OBRIGATORIO")]
        [StringLength(6)]
        public string placa { get; set; }

    }
}
