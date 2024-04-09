using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Pizzaria.Domain.Models
{
    [Table("tbAvaliacao")]
    public partial class TbAvaliacao
    {
        [Key]
        public int IdAvaliacao { get; set; }
        [StringLength(30)]
        public string Titulo { get; set; }
        [StringLength(50)]
        public string Comentario { get; set; }
        public int? Nota { get; set; }
        [StringLength(1)]
        public string Ativo { get; set; }
    }
}
