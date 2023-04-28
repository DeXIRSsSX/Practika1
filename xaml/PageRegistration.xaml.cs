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
    /// Логика взаимодействия для PageRegistration.xaml
    /// </summary>
    public partial class PageRegistration : Page
    {
        public PageRegistration()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.Navigate(new xaml.PageLogin());
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (OdbConnectHelper.entObj.User.Count(x => x.Login == Txblogin.Text) > 0)
            {
                MessageBox.Show("опять ввел того же дурачка", "Весточка", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            else
            {
                try

                {
                    User UserObj = new User()
                    {
                        Login = Txblogin.Text,
                        Password = PsbPassword.Password,
                        IdRole = 1
                    };

                    OdbConnectHelper.entObj.User.Add(UserObj);
                    OdbConnectHelper.entObj.SaveChanges();
                    MessageBox.Show("Парнишка теперь при делах", "Весточка", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибочка:" + ex.Message.ToString(), "Крит урон по работе", MessageBoxButton.OK, MessageBoxImage.Warning);
                }


            }
        }

        private void PsbPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (TxbPassword.Text == PsbPassword.Password)
            {
                BtnCreate.IsEnabled = true;
                PsbPassword.Background = Brushes.Green;
                PsbPassword.BorderBrush = Brushes.LightGreen;
            }
            else
            {
                BtnCreate.IsEnabled = false;
                PsbPassword.Background = Brushes.LightCoral;
                PsbPassword.BorderBrush = Brushes.Red;
            }
        }

        
        
    }
}
        

 