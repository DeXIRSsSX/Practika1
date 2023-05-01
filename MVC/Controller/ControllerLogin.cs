using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.MVC.View;

namespace WpfApp3.MVC.Controller
{
    internal class ControllerLogin
    {
        public static string CheckLoginOdb (string loginCheck)
        {
            ViewLogin viewLogin = new ViewLogin ();
            return viewLogin.GetLogin(loginCheck);
        }
    }
}
