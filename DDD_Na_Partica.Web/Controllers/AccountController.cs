using DDD_Na_Partica.Application.IppServices;
using DDD_Na_Partica.Domain.Entities;
using DDD_Na_Partica.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DDD_Na_Partica.Web.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IAppServiceUsuario appServiceUsuario;

        public AccountController(IAppServiceUsuario _appServiceUsuario)
        {
            appServiceUsuario = _appServiceUsuario;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {

                var usu = appServiceUsuario.LoginUsuario(login.Senha, login.Nome);

                if (usu == null)
                {
                    Warning("Login e/ou senha inválido", true);
                    return View(login);
                }
                else
                {
                    if (!usu.Ativo)
                    {
                        Warning("Este usuário está bloqueado", true);
                        return View(login);
                    }
                    else
                    {
                        var authTicket = new FormsAuthenticationTicket(
                            1,
                            usu.Nome,
                            DateTime.Now,
                            DateTime.Now.AddMinutes(30),
                            false,
                            usu.Permissao,
                            FormsAuthentication.FormsCookiePath
                            );

                        var authCrypt = FormsAuthentication.Encrypt(authTicket);

                        var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, authCrypt);

                        HttpContext.Response.Cookies.Add(authCookie);

                        return RedirectToAction("Index", "Home");

                    }
                }
            }
            else
            {
                return View(login);
            }
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login", "Account");
        }
    }
}