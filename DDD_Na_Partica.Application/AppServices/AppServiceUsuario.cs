using DDD_Na_Partica.Application.IppServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD_Na_Partica.Domain.Entities;

namespace DDD_Na_Partica.Application.AppServices
{
    public class AppServiceUsuario : IAppServiceUsuario
    {
       
        public AppServiceUsuario()
        {

        }

        public Usuario LoginUsuario(string senha, string usuario)
        {
            throw new NotImplementedException();
        }
    }
}
