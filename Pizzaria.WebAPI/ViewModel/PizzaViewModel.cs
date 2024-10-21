using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.ViewModel
{


    public class PizzaViewModel
    {
        public int IdPizza { get; set; }
        [StringLength(20)]
        public string Nome { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Preco { get; set; }
        public int? Tamanho { get; set; }

        public List<String> Ingredientes {get;set;}



    }



}