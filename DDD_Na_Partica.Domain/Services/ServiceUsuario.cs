using DDD_Na_Partica.Domain.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD_Na_Partica.Domain.Entities;
using DDD_Na_Partica.Domain.Interfaces.IRepositories;

namespace DDD_Na_Partica.Domain.Services
{
    public class ServiceUsuario : IServiceUsuario
    {
        private readonly IRepositoryUsuario repositoryUsuario;
        public ServiceUsuario(IRepositoryUsuario _repositoryUsuario)
        {
            repositoryUsuario = _repositoryUsuario;
        }

        public Usuario LoginUsuario(string senha, string usuario)
        {
            return repositoryUsuario.LoginUsuario(senha, usuario);
        }
    }
}
