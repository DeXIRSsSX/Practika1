using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.DB;

namespace WpfApp3.MVC.HelpController
{
    internal class DataBaseController
    {
        public static string GetLoginMain (string getSetLogin)
        {
            User userObj = OdbConnectHelper.entObj.User.FirstOrDefault(x => x.Login == getSetLogin);
            while (true)
            {
                if (userObj != null)
                {
                    return "Пользователь есть";
                }
                else
                {
                    return "Такоего пользователя нету ";
                }
            }
        }
    }
}
