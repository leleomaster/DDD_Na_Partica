using DDD_Na_Partica.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDD_Na_Partica.Web.Controllers
{
    // https://www.youtube.com/watch?v=ywWWhIJYoDY&list=PLKzcE63mS1V1zvjQViINZAaFliO0-NDIM&index=7

    /*
    teste
     * Fazer depois Curso de TDD mais nUnit
     https://www.youtube.com/playlist?list=PLb2HQ45KP0WvzEKQ56AZ7j5-Gsay9yPOg
     */


    public class UsuarioController : Controller
    {
        private static List<UsuarioViewModel> ListaUsuario = null;

        public UsuarioController()
        {
            ListaUsuario = GetUsuarios();
        }

        public ActionResult Index()
        {

            var models = ListaUsuario;

            return View(models);
        }

        public ActionResult CadAlter(int? idUsuario)
        {
            if (idUsuario == null || idUsuario == 0)
            {
                // Cadastrar
                return View();
            }
            else
            {
                var usuario = ListaUsuario.FirstOrDefault(u => u.Id == idUsuario);
                return View(usuario);
            }
        }
        [HttpPost]
        public ActionResult CadAlter(UsuarioViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CadastrarUsuario(model);

                    return View("Index", ListaUsuario);
                }
                else
                {

                    return View(model);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void CadastrarUsuario(UsuarioViewModel model)
        {

            var usuarios = ListaUsuario;

            usuarios.Add(model);
        }

        public static List<UsuarioViewModel> GetUsuarios()
        {
            return new List<UsuarioViewModel>()
            {
                new UsuarioViewModel
                {
                    Id = 1,
                    Login = "PRI",
                    Nome = "Priscila",
                    Senha = "568789",
                    Ativo = false
                },
                new UsuarioViewModel
                {
                    Id = 2,
                    Login = "sandra",
                    Nome = "Sandra",
                    Senha = "5687654",
                    Ativo = false
                },
                new UsuarioViewModel
                {
                    Id = 3,
                    Login = "leleo",
                    Nome = "Leonardo",
                    Senha = "12354",
                    Ativo = true
                },
            };
        }
    }
}
