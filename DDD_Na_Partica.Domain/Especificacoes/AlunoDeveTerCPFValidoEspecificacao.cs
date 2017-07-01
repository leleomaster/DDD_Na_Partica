using DDD_Na_Partica.Domain.Entities;
using DDD_Na_Partica.Domain.Validations.Documentos;
using DomainValidation.Interfaces.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Na_Partica.Domain.Especificacoes
{
    public class AlunoDeveTerCPFValidoEspecificacao : ISpecification<Aluno>
    {
        public bool IsSatisfiedBy(Aluno aluno)
        {
            return CPFValidation.Validar(aluno.CPF);
        }
    }
}
