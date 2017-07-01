using DDD_Na_Partica.Domain.Entities;
using DDD_Na_Partica.Domain.Especificacoes;
using DomainValidation.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Na_Partica.Domain.Validations.Alunos
{
    public class AlunoConsistenteValidation : Validator<Aluno>
    {
        public AlunoConsistenteValidation()
        {
            var CPFAluno = new AlunoDeveTerCPFValidoEspecificacao();
            var alunoFaixaEtaria = new AlunoDeveTerIdadeEntre6a18Especificacao();

            base.Add("CPFAluno", new Rule<Aluno>(CPFAluno, "Aluno informou um CPF inválido."));
            base.Add("alunoFaixaEtaria", new Rule<Aluno>(alunoFaixaEtaria, "Aluno não se enquadra na faixa etária da escola."));
        }
    }
}
