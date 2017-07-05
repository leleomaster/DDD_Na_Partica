using DDD_Na_Partica.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace DDD_Na_Partica.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            BundleConfig.RegisterBundle(BundleTable.Bundles);
        }

        /// <summary>
        /// Autenticação por requisição
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_AuthenticateRequest(Object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                HttpCookie authCookie = Context.Request.Cookies[FormsAuthentication.FormsCookieName];

                if (authCookie == null || authCookie.Value == string.Empty)
                {
                    return;
                }

                FormsAuthenticationTicket authTicket;

                try
                {
                    authTicket = FormsAuthentication.Decrypt(authCookie.Value);
                }
                catch (Exception)
                {

                    throw;
                }

                string[] roles = authTicket.UserData.Split(';');

                if (Context.User != null)
                {
                    Context.User = new GenericPrincipal(Context.User.Identity, roles);
                }
            }
        }

        /// <summary>
        /// Verificação de Autenticação do Form Authentication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void FormsAuthentication_OnAuthenticate(Object sender, FormsAuthenticationEventArgs forms)
        {
            if (FormsAuthentication.CookiesSupported == true)
            {
                if (Request.Cookies[FormsAuthentication.FormsCookieName] != null)
                {
                    try
                    {
                        HttpCookie authCookie = Context.Request.Cookies[FormsAuthentication.FormsCookieName];

                        FormsAuthenticationTicket authTicket;

                        try
                        {
                            authTicket = FormsAuthentication.Decrypt(authCookie.Value);
                        }
                        catch (Exception)
                        {
                            //log
                            return;
                        }

                        // Recupera as funções a partir do UserData
                        string[] roles = authTicket.UserData.Split(';');

                        if (Context.User != null)
                        {
                            Context.User = new GenericPrincipal(Context.User.Identity, roles);
                        }

                        forms.User = new GenericPrincipal(new GenericIdentity(authCookie.Name, "Forms"), roles);

                    }
                    catch (Exception)
                    {
                        //log
                    }
                }
            }
        }

        /// <summary>
        /// Autenticação de POST
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_PostAuthenticateRequest(Object sender, EventArgs e)
        {
            if (FormsAuthentication.CookiesSupported == true)
            {
                if (Request.Cookies[FormsAuthentication.FormsCookieName] != null)
                {
                    try
                    {
                        HttpCookie authCookie = Context.Request.Cookies[FormsAuthentication.FormsCookieName];

                        FormsAuthenticationTicket authTicket;

                        try
                        {
                            authTicket = FormsAuthentication.Decrypt(authCookie.Value);
                        }
                        catch (Exception)
                        {
                            //log
                            return;
                        }

                        // Recupera as funções a partir do UserData
                        string[] roles = authTicket.UserData.Split(';');

                        if (Context.User != null)
                        {
                            Context.User = new GenericPrincipal(Context.User.Identity, roles);
                        }

                        HttpContext.Current.User = new GenericPrincipal(new GenericIdentity(authTicket.Name, "Forms"), roles);

                    }
                    catch (Exception)
                    {
                        //log
                    }
                }
            }
        }

    }
}
