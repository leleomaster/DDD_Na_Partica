using DDD_Na_Partica.Application.IppServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD_Na_Partica.Domain.Entities;
using DDD_Na_Partica.Domain.Interfaces.IServices;

namespace DDD_Na_Partica.Application.AppServices
{
    public class AppServiceUsuario : IAppServiceUsuario
    {
        private readonly IServiceUsuario serviceUsuario;

        public AppServiceUsuario(IServiceUsuario _serviceUsuario)
        {
            serviceUsuario = _serviceUsuario;
        }

        public Usuario LoginUsuario(string senha, string usuario)
        {
            return serviceUsuario.LoginUsuario(senha, usuario);
        }
    }
}
