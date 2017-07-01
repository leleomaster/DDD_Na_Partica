using DDD_Na_Partica.Domain.Validations.Alunos;
using DomainValidation.Validation;
using System;

namespace DDD_Na_Partica.Domain.Entities
{
    public class Aluno
    {
        public Aluno()
        {
            AlunoId = Guid.NewGuid();
        }
        public Guid AlunoId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            ValidationResult = new AlunoConsistenteValidation().Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
