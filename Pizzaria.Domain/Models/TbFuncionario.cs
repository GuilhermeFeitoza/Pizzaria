using System;
using System.Collections.Generic;

#nullable disable

namespace Pizzaria.Domain.Models
{
    public partial class TbFuncionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Ativo { get; set; }
    }
}
