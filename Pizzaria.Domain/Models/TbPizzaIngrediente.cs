﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Pizzaria.Domain.Models
{
    public partial class TbPizzaIngrediente
    {
        public int IdPizzaIngrediente { get; set; }
        public int? IdPizza { get; set; }
        public int? IdIngrediente { get; set; }

        public virtual TbIngrediente IdIngredienteNavigation { get; set; }
        public virtual TbPizza IdPizzaNavigation { get; set; }
    }
}
