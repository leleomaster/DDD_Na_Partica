using DDD_Na_Partica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Na_Partica.Domain.Interfaces.IRepositories
{
   public interface IPessoaRepository
    {
        IEnumerable<TBLPessoa> GetList();
        TBLPessoa GetPessoaById(int id);
        int InsertPessoa(TBLPessoa pessoa);
        bool UpdatePessoa(TBLPessoa pessoa);
    }
}
