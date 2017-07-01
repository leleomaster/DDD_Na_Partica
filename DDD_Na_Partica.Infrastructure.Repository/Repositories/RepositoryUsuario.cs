using DDD_Na_Partica.Domain.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD_Na_Partica.Domain.Entities;

namespace DDD_Na_Partica.Infrastructure.Repository.Repositories
{
    public class RepositoryUsuario : IRepositoryUsuario
    {
        public Usuario LoginUsuario(string senha, string usuario)
        {
            throw new NotImplementedException();
        }
    }
}
