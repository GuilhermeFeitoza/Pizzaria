using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAPI.Models
{
    [Keyless]
    [Table("tbBebidas")]
    public partial class TbBebida
    {
        public int IdBebida { get; set; }
        [StringLength(20)]
        public string Nome { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Preco { get; set; }
        [StringLength(1)]
        public string Ativo { get; set; }
    }
}
