﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Pizzaria.Domain.Models
{
    public partial class TbIngrediente
    {
        public TbIngrediente()
        {
            TbPizzaIngredientes = new HashSet<TbPizzaIngrediente>();
        }

        public int IdIngrediente { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int? QtdCal { get; set; }
        public decimal? Preco { get; set; }

        public virtual ICollection<TbPizzaIngrediente> TbPizzaIngredientes { get; set; }
    }
}
