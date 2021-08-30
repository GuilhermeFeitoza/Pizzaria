using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class TbCliente
    {
        public TbCliente()
        {
            TbUsuarios = new HashSet<TbUsuario>();
        }

        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Ativo { get; set; }

        public virtual ICollection<TbUsuario> TbUsuarios { get; set; }
    }
}
