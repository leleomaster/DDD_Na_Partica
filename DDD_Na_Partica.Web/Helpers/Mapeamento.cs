using DDD_Na_Partica.Domain.Entities;
using DDD_Na_Partica.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDD_Na_Partica.Web.Helpers
{
    public class Mapeamento
    {
        public static IEnumerable<PessoaViewModel> GetListDtoToListModel(IEnumerable<TBLPessoa> listaPessoa)
        {
            List<PessoaViewModel> listaRetono = null;

            if (listaPessoa != null && listaPessoa.Count() == 0)
            {
                listaRetono = new List<PessoaViewModel>();

                foreach (var item in listaPessoa)
                {
                    listaRetono.Add(new PessoaViewModel()
                    {
                        Nome = item.Nome,
                        CPFPessoa = item.CPFPessoa,
                        DataCadastroPessoa = item.DataCadastroPessoa,
                        FlagAtivoPessoa = item.FlagAtivoPessoa,
                        IdPessoa = item.IdPessoa,
                        Usuario = new UsuarioViewModel()
                        {
                            Id = item.Usuario.IdUsuario,
                            IdPessoa = item.Usuario.IdPessoa,
                            Login = item.Usuario.LoginUsuario,
                            Senha = item.Usuario.SenhaUsuario
                        }

                    });
                }
            }
            return listaRetono;
        }

        public static PessoaViewModel PessoaDtoToPessoaViewModel(TBLPessoa pesssoa)
        {
            return new PessoaViewModel()
            {
                Nome = pesssoa.Nome,
                CPFPessoa = pesssoa.CPFPessoa,
                DataCadastroPessoa = pesssoa.DataCadastroPessoa,
                FlagAtivoPessoa = pesssoa.FlagAtivoPessoa,
                IdPessoa = pesssoa.IdPessoa,
                Usuario = new UsuarioViewModel()
                {
                    Id = pesssoa.Usuario.IdUsuario,
                    IdPessoa = pesssoa.Usuario.IdPessoa,
                    Login = pesssoa.Usuario.LoginUsuario,
                    Senha = pesssoa.Usuario.SenhaUsuario
                }
            };
        }

        public static TBLPessoa PessoaViewModelToPessoaDto(PessoaViewModel pesssoaVM)
        {
            return new TBLPessoa()
            {
                Nome = pesssoaVM.Nome,
                CPFPessoa = pesssoaVM.CPFPessoa,
                DataCadastroPessoa = pesssoaVM.DataCadastroPessoa,
                FlagAtivoPessoa = pesssoaVM.FlagAtivoPessoa,
                IdPessoa = pesssoaVM.IdPessoa,
                Usuario = new TBLUsuario()
                {
                    IdUsuario = pesssoaVM.Usuario.Id,
                    IdPessoa = pesssoaVM.Usuario.IdPessoa,
                    LoginUsuario = pesssoaVM.Usuario.Login,
                    SenhaUsuario = pesssoaVM.Usuario.Senha
                }
            };
        }
    }

}