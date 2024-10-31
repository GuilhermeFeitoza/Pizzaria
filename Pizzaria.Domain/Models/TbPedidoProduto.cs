using System;
using System.Collections.Generic;

#nullable disable

namespace Pizzaria.Domain.Models
{
    public partial class TbPedidoProduto
    {
        public int IdPedidoProduto { get; set; }
        public int? IdPedido { get; set; }
        public int? IdPizza { get; set; }
        public int? IdBebida { get; set; }

        public virtual TbBebida IdBebidaNavigation { get; set; }
        public virtual TbPedido IdPedidoNavigation { get; set; }
        public virtual TbPizza IdPizzaNavigation { get; set; }
    }
}
