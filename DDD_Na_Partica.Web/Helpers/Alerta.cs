using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDD_Na_Partica.Web.Helpers
{
    public class Alerta
    {
        public const string TempDataKey = "TempDataAlerta";

        public string AlertaStyle { get; set; }

        public string Message { get; set; }

        public bool Dismissable { get; set; }
    }


    public static class AlertaStyle
    {
        public const string Success = "success";

        public const string Information = "info";

        public const string Warning = "warning";

        public const string Danger = "danger";
    }
}