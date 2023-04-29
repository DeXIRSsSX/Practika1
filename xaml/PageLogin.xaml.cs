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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp3.ClassHelper;
using WpfApp3.DB;


namespace WpfApp3.xaml
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();

            if (Properties.Settings.Default.EventSaveLogin != string.Empty)
            {
                TxbLogin.Text = Properties.Settings.Default.EventSaveLogin;
            }
        }
        public void RememberMe()
        {
            if  (ChkSaveLogin.IsChecked == true)
            {
                Properties.Settings.Default.EventSaveLogin = TxbLogin.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.EventSaveLogin = "";
                Properties.Settings.Default.Save();
            }
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.Navigate(new xaml.PageRegistration());
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = OdbConnectHelper.entObj.User.FirstOrDefault(
                    x => x.Login == TxbLogin.Text && x.Password == PsbPassword.Password);
                if (userObj == null)
                {
                    MessageBox.Show("Такого пользователя нету!","Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                    FrameApp.frnObj.Navigate(new PageRegistration());
                }
                else
                {
                    UserControlHelp.IdUser = userObj.id;
                    switch (userObj.IdRole)
                    {
                        case 1:
                           /* RememberMe();*/
                            /*UserControlHelp.LoginUser = TxbLogin.Text;*/
                            FrameApp.frnObj.Navigate(new PageStudent());
                            break;
                        case 2:
                            /*RememberMe();*/
                            FrameApp.frnObj.Navigate(new PageTeacher());
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка","Уведомление" + ex.Message.ToString(),
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                                   
            }

                

        }
    }
}
