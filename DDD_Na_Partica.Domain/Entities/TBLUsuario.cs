using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Na_Partica.Domain.Entities
{
   public  class TBLUsuario
    {
        public int IdUsuario { get; set; }

        public int IdPessoa { get; set; }

        public string LoginUsuario { get; set; }

        public string SenhaUsuario { get; set; }
    }
}
