using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class TbUsuario
    {
        public int IdUsuario { get; set; }
        public int? IdCliente { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Ativo { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; }
    }
}
