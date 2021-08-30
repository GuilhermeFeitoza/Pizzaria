using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class TbAvaliacao
    {
        public int IdAvaliacao { get; set; }
        public string Titulo { get; set; }
        public string Comentario { get; set; }
        public int? Nota { get; set; }
        public string Ativo { get; set; }
    }
}
