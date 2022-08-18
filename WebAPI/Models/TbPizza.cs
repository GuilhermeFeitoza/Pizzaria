using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class TbPizza
    {
        public int IdPizza { get; set; }
        public string Nome { get; set; }
        public decimal? Preco { get; set; }
        public int? Tamanho { get; set; }
    }
}
