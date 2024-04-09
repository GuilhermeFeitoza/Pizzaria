using System;

namespace WebAPI.ViewModel{


    public class FuncionarioViewModel {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Ativo { get; set; }


    }



}