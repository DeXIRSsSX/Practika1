using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.ClassHelper
{
    /// <summary>
    /// Обработка данных пользователя
    /// </summary>
    internal class UserControlHelp
    {
        public static int IdUser { get; set; }
        public static string Password { get; set; }
        public static string LoginUser { get; set; } = "Нет логина";
    }
}
