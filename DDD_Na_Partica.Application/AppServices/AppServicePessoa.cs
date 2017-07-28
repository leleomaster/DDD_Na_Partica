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
    public class AppServicePessoa : IAppServicePessoa
    {
        private readonly IServicePessoa serviceUsuario;

        public AppServicePessoa(IServicePessoa _serviceUsuario)
        {
            serviceUsuario = _serviceUsuario;
        }
        public IEnumerable<TBLPessoa> GetList()
        {
                return            serviceUsuario.GetList();
        }

        public TBLPessoa GetPessoaById(int id)
        {
            return serviceUsuario.GetPessoaById(id);
        }

        public int InsertPessoa(TBLPessoa pessoa)
        {
            return serviceUsuario.InsertPessoa(pessoa);
        }

        public bool UpdatePessoa(TBLPessoa pessoa)
        {
            return serviceUsuario.UpdatePessoa(pessoa);
        }
    }
}
