using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class TbIngrediente
    {
        public int IdIngrediente { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int? QtdCal { get; set; }
    }
}
