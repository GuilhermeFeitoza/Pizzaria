using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Pizzaria.Domain.Models
{
    [Table("tbIngredientes")]
    public partial class TbIngrediente
    {
        public TbIngrediente()
        {
            TbPizzaIngredientes = new HashSet<TbPizzaIngrediente>();
        }

        [Key]
        public int IdIngrediente { get; set; }
        [StringLength(30)]
        public string Nome { get; set; }
        [StringLength(20)]
        public string Descricao { get; set; }
        public int? QtdCal { get; set; }

        [InverseProperty(nameof(TbPizzaIngrediente.IdIngredienteNavigation))]
        public virtual ICollection<TbPizzaIngrediente> TbPizzaIngredientes { get; set; }
    }
}
