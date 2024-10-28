using System;
using System.Collections.Generic;

#nullable disable

namespace Pizzaria.Domain.Models
{
    public partial class TbPizza
    {
        public TbPizza()
        {
            TbPedidoProdutos = new HashSet<TbPedidoProduto>();
            TbPizzaIngredientes = new HashSet<TbPizzaIngrediente>();
        }

        public int IdPizza { get; set; }
        public string Nome { get; set; }
        public decimal? Preco { get; set; }
        public int? Tamanho { get; set; }

        public virtual ICollection<TbPedidoProduto> TbPedidoProdutos { get; set; }
        public virtual ICollection<TbPizzaIngrediente> TbPizzaIngredientes { get; set; }
    }
}
