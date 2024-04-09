using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAPI.Models
{
    [Table("tbPizza_Ingrediente")]
    public partial class TbPizzaIngrediente
    {
        [Key]
        public int IdPizzaIngrediente { get; set; }
        public int? IdPizza { get; set; }
        public int? IdIngrediente { get; set; }

        [ForeignKey(nameof(IdIngrediente))]
        [InverseProperty(nameof(TbIngrediente.TbPizzaIngredientes))]
        public virtual TbIngrediente IdIngredienteNavigation { get; set; }
        [ForeignKey(nameof(IdPizza))]
        [InverseProperty(nameof(TbPizza.TbPizzaIngredientes))]
        public virtual TbPizza IdPizzaNavigation { get; set; }
    }
}
