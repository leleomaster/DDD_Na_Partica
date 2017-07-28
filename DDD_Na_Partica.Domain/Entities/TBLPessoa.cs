using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Na_Partica.Domain.Entities
{
    public class TBLPessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string CPFPessoa { get; set; }
        public bool FlagAtivoPessoa { get; set; }
        public string DataCadastroPessoa { get; set; }
        public TBLUsuario Usuario { get; set; }
    }
}
