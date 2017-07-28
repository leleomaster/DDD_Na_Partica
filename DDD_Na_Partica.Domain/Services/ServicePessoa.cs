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
    public class ServicePessoa : IServicePessoa
    {
        private readonly IPessoaRepository pessoaRepository;

        public ServicePessoa(IPessoaRepository _pessoaRepository)
        {
            pessoaRepository = _pessoaRepository;
        }

        public IEnumerable<TBLPessoa> GetList()
        {
           return pessoaRepository.GetList();
        }

        public TBLPessoa GetPessoaById(int id)
        {
            return pessoaRepository.GetPessoaById(id);
        }

        public int InsertPessoa(TBLPessoa pessoa)
        {
            return pessoaRepository.InsertPessoa(pessoa);
        }

        public bool UpdatePessoa(TBLPessoa pessoa)
        {
            return pessoaRepository.UpdatePessoa(pessoa);
        }
    }
}
