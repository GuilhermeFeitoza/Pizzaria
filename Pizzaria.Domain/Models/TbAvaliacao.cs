﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Pizzaria.Domain.Models
{
    public partial class TbAvaliacao
    {
        public int IdAvaliacao { get; set; }
        public string Titulo { get; set; }
        public string Comentario { get; set; }
        public string NomeAvaliador { get; set; }
        public DateTime? DataPedido { get; set; }
        public int? Nota { get; set; }
        public string Ativo { get; set; }
        public int? IdPedido { get; set; }

        public virtual TbPedido IdPedidoNavigation { get; set; }
    }
}
