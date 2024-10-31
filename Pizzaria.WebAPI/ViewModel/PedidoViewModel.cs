using System;
using System.Collections.Generic;

#nullable disable

namespace Pizzaria.WebAPI.ViewModel
{
    public class PedidoViewModel
    {
        public int IdPedido { get; set; }
        public string StatusPedido { get; set; }
        public decimal? ValorPedido { get; set; }
        public string TipoPedido { get; set; }
        public DateTime? DataPedido { get; set; }
        public string FormaPagamentoPedido { get; set; }
        public string Endereco { get; set; }

        public List<ItenPedido> ItensPedidos {get;set;}
    }
    public class ItenPedido {
        public int id {get;set;}
        public string nome {get;set;}

        public decimal valor {get;set;}

        public string tipoProduto{get;set;}

    }

}
