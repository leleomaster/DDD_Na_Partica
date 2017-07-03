using DDD_Na_Partica.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDD_Na_Partica.Web.Controllers
{
    public class BaseController : Controller
    {
        public void AddAlert(string alertaStyle, string message, bool dismissable)
        {
            var alertas = TempData.ContainsKey(Alerta.TempDataKey)
                ? (List<Alerta>)TempData[Alerta.TempDataKey]
                : new List<Alerta>();

            alertas.Add(new Alerta()
            {
                AlertaStyle = alertaStyle,
                Dismissable = dismissable,
                Message = message
            });

            TempData[Alerta.TempDataKey] = alertas;
        }

        public void Success(string message, bool dismissable = false)
        {
            AddAlert(AlertaStyle.Success, message, dismissable);
        }

        public void Information(string message, bool dismissable = false)
        {
            AddAlert(AlertaStyle.Information, message, dismissable);
        }

        public void Warning(string message, bool dismissable = false)
        {
            AddAlert(AlertaStyle.Warning, message, dismissable);
        }

        public void Danger(string message, bool dismissable = false)
        {
            AddAlert(AlertaStyle.Danger, message, dismissable);
        }

        public ActionResult ExibirMessages()
        {
            return View("_Alerta");
        }
    }
}