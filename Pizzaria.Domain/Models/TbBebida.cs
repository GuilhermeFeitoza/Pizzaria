using System;
using System.Collections.Generic;

#nullable disable

namespace Pizzaria.Domain.Models
{
    public partial class TbBebida
    {
        public TbBebida()
        {
            TbPedidoProdutos = new HashSet<TbPedidoProduto>();
        }

        public int IdBebida { get; set; }
        public string Nome { get; set; }
        public decimal? Preco { get; set; }
        public string Ativo { get; set; }

        public virtual ICollection<TbPedidoProduto> TbPedidoProdutos { get; set; }
    }
}
