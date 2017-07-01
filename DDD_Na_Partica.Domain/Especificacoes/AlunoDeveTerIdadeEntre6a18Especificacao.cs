using DDD_Na_Partica.Domain.Entities;
using DomainValidation.Interfaces.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Na_Partica.Domain.Especificacoes
{
    public class AlunoDeveTerIdadeEntre6a18Especificacao : ISpecification<Aluno>
    {
        public bool IsSatisfiedBy(Aluno aluno)
        {
            return (DateTime.Now.Year - aluno.DataNascimento.Year >= 6
                    && 
                    DateTime.Now.Year - aluno.DataNascimento.Year <= 18);
        }
    }
}
