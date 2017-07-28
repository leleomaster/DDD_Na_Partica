using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDD_Na_Partica.Web.Models
{
    public class PessoaViewModel
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string CPFPessoa { get; set; }
        public bool FlagAtivoPessoa { get; set; }
        public string DataCadastroPessoa { get; set; }
        public UsuarioViewModel Usuario { get; set; }
    }
}