using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.MVC.HelpController;

namespace WpfApp3.MVC.View
{
    internal class ViewLogin
    {
        public string GetLogin(string loginCheckOdb)
        {
            return DataBaseController.GetLoginMain(loginCheckOdb);
        }
    }
}
