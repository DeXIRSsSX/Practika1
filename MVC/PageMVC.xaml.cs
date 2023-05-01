using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp3.DB;
using WpfApp3.MVC.Controller;
using WpfApp3.MVC.HelpController;

namespace WpfApp3.MVC
{
    /// <summary>
    /// Логика взаимодействия для PageMVC.xaml
    /// </summary>
    public partial class PageMVC : Page
    {
        public PageMVC()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            Clientinfo.LoginCheck = TxtLogin.Text;
           // ControllerLogin controllerLogin = new ControllerLogin();

            MessageBox.Show(ControllerLogin.CheckLoginOdb(TxtLogin.Text));
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.GoBack();
        }
    }
}
