using DDD_Na_Partica.Application.IppServices;
using DDD_Na_Partica.Web.Helpers;
using DDD_Na_Partica.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDD_Na_Partica.Web.Controllers
{
    public class PessoaController : Controller
    {
        private readonly IAppServicePessoa appServicePessoa;

        public PessoaController(IAppServicePessoa _appServicePessoa)
        {
            appServicePessoa = _appServicePessoa;
        }

        public ActionResult Index()
        {
            var modelList = appServicePessoa.GetList();

            var list = Mapeamento.GetListDtoToListModel(modelList);

            return View(list);
        }

        public ActionResult CadastrarAlterar(int? id)
        {
            if (id == null)
            {
                var model = new PessoaViewModel();
                model.Usuario = new UsuarioViewModel();
                return View(model);
            }
            else
            {
                var model = Mapeamento.PessoaDtoToPessoaViewModel(appServicePessoa.GetPessoaById(id ?? 0));
                return View(model);
            }
        }


    }
}