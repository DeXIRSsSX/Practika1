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
                    X => X.Login == TxbLogin.Text && X.Password == PsbPassword.Password);
                if (userObj == null)
                {
  MessageBox.Show("Такого пользователя нету!","Ананас",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                    FrameApp.frnObj.Navigate(new PageRegistration());
                }
                else
                {
                    switch (userObj.IdRole)
                    {
                        case 1:
                            //MessageBox.Show("Салам попалам Student", "Весточка" ,
                            // MessageBoxButton.OK,
                            // MessageBoxImage.Warning);

                            FrameApp.frnObj.Navigate(new PageStudent());
                            break;
                        case 2:
                            // MessageBox.Show("Салам сенсей", "Весточка" ,
                            //MessageBoxButton.OK,
                            // MessageBoxImage.Warning);
                            FrameApp.frnObj.Navigate(new PageTeacher());
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("а","Ананас" + ex.Message.ToString(),
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                                   
            }

                

        }
    }
}
