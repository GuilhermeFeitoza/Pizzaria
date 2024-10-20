using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Pizzaria.Domain.Models
{
    [Table("tbFuncionario")]
    public partial class TbFuncionario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Nome { get; set; }
        [Required]
        [StringLength(30)]
        public string Usuario { get; set; }
        [Required]
        [StringLength(200)]
        public string Senha { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DataAdmissao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DataNascimento { get; set; }
        [Required]
        [StringLength(1)]
        public string Ativo { get; set; }

     
    }
}
