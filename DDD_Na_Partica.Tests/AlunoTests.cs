using DDD_Na_Partica.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Na_Partica.Tests
{
    [TestClass]
    public class AlunoTests
    {
        public Aluno Aluno { get; set; }

        [TestMethod]
        public void Aluno_Valido_True()
        {
            Aluno = new Aluno()
            {
                CPF = "65560639834", //informando CPF válido
                DataNascimento = new DateTime(2005, 01, 01) // informando data nascimento válida para cadastro
            };

            Assert.IsTrue(Aluno.IsValid());
        }

        [TestMethod]
        public void Aluno_Valido_False()
        {
            Aluno = new Aluno()
            {
                CPF = "65560639800", //informando CPF inválido
                DataNascimento = new DateTime(1995, 01, 01) // informando data nascimento inválida 
            };

            Assert.IsFalse(Aluno.IsValid());
            Assert.IsTrue(Aluno.ValidationResult.Erros.Any(e => e.Message == "Aluno informou um CPF inválido."));
            Assert.IsTrue(Aluno.ValidationResult.Erros.Any(e => e.Message == "Aluno não se enquadra na faixa etária da escola."));
        }
    }
}
