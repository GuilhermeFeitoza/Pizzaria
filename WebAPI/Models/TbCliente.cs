using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAPI.Models
{
    [Table("tbCliente")]
    public partial class TbCliente
    {
        public TbCliente()
        {
            TbUsuarios = new HashSet<TbUsuario>();
        }

        [Key]
        public int IdCliente { get; set; }
        [Required]
        [StringLength(200)]
        public string Nome { get; set; }
        [Required]
        [StringLength(11)]
        public string Cpf { get; set; }
        [Required]
        [StringLength(30)]
        public string Email { get; set; }
        [Required]
        [StringLength(12)]
        public string Telefone { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DataNascimento { get; set; }
        [Required]
        [StringLength(1)]
        public string Ativo { get; set; }


[NotMapped]
        [InverseProperty(nameof(TbUsuario.IdClienteNavigation))]
        public virtual ICollection<TbUsuario> TbUsuarios { get; set; }
    }
}
