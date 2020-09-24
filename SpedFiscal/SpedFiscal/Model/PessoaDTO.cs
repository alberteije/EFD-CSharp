using System;
using System.Text;
using System.Collections.Generic;


namespace SpedFiscal.Model {
    
    public class PessoaDTO {
        public PessoaDTO() { }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public string Cliente { get; set; }
        public string Fornecedor { get; set; }
        public string Colaborador { get; set; }
        public string Convenio { get; set; }
        public string Contador { get; set; }
        public string Transportadora { get; set; }
    }
}
