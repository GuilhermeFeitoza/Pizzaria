using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Pizzaria.Domain.Models
{
    [Table("tbUsuario")]
    public partial class TbUsuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public int? IdCliente { get; set; }
        [StringLength(20)]
        public string Nome { get; set; }
        [StringLength(200)]
        public string Senha { get; set; }
        [StringLength(1)]
        public string Ativo { get; set; }


        [NotMapped]
        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(TbCliente.TbUsuarios))]
        public virtual TbCliente IdClienteNavigation { get; set; }
    }
}
