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
            try
            {
                if (senha == "123" && usuario == "leo")
                {
                    Usuario usuar = new Usuario()
                    {
                        Ativo = true,
                        Id = 1,
                        Login = "leleo_0",
                        Nome = "Leonardo",
                        Senha = "*********",
                        Permissao = "Cursos;UsuarioCadastro"
                    };

                    return usuar;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
