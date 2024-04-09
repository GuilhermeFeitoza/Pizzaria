using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAPI.Models
{
    [Table("tbPedido")]
    public partial class TbPedido
    {
        [Key]
        public int IdPedido { get; set; }
        [StringLength(1)]
        public string StatusPedido { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? ValorPedido { get; set; }
        [StringLength(1)]
        public string TipoPedido { get; set; }
        [StringLength(20)]
        public string FormaPagamentoPedido { get; set; }
    }
}
