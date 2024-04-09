using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Pizzaria.Domain.Models
{
    [Table("tbPizza")]
    public partial class TbPizza
    {
        public TbPizza()
        {
            TbPizzaIngredientes = new HashSet<TbPizzaIngrediente>();
        }

        [Key]
        public int IdPizza { get; set; }
        [StringLength(20)]
        public string Nome { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Preco { get; set; }
        public int? Tamanho { get; set; }

        [InverseProperty(nameof(TbPizzaIngrediente.IdPizzaNavigation))]
        public virtual ICollection<TbPizzaIngrediente> TbPizzaIngredientes { get; set; }
    }
}
