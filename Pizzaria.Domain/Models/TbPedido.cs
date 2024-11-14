using System;
using System.Collections.Generic;

#nullable disable

namespace Pizzaria.Domain.Models
{
    public partial class TbPedido
    {
        public TbPedido()
        {
            TbAvaliacaos = new HashSet<TbAvaliacao>();
            TbPedidoProdutos = new HashSet<TbPedidoProduto>();
        }

        public int IdPedido { get; set; }
        public string StatusPedido { get; set; }
        public decimal? ValorPedido { get; set; }
        public string TipoPedido { get; set; }
        public DateTime? DataPedido { get; set; }
        public string FormaPagamentoPedido { get; set; }
        public string Endereco { get; set; }

        public virtual ICollection<TbAvaliacao> TbAvaliacaos { get; set; }
        public virtual ICollection<TbPedidoProduto> TbPedidoProdutos { get; set; }
    }
}
