using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDD_Na_Partica.Web.Models
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public bool Ativo { get; set; }
    }
}