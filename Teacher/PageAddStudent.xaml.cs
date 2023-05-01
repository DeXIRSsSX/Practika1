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

namespace WpfApp3.Teacher
{
    /// <summary>
    /// Логика взаимодействия для PageAddStudent.xaml
    /// </summary>
    public partial class PageAddStudent : Page
    {
        public PageAddStudent()
        {
            InitializeComponent();
            CmbSpecial.SelectedValuePath = "id";
            CmbSpecial.DisplayMemberPath = "Name";
            CmbSpecial.ItemsSource = OdbConnectHelper.entObj.Special.ToList();

            CmbFormTime.SelectedValuePath = "id";
            CmbFormTime.DisplayMemberPath = "Name";
            CmbFormTime.ItemsSource = OdbConnectHelper.entObj.FormTime.ToList();

            CmbYear.SelectedValuePath = "id";
            CmbYear.DisplayMemberPath = "Year";
            CmbYear.ItemsSource = OdbConnectHelper.entObj.YearAdd.ToList();

            CmbNameGroup.SelectedValuePath = "id";
            CmbNameGroup.DisplayMemberPath = "Name";
            CmbNameGroup.ItemsSource = OdbConnectHelper.entObj.NameGroup.ToList();
        }
        /// <summary>
        /// Логика работы добавление студента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Student stdObj = new Student()
                {
                    Name = TxbNameStudent.Text,
                    NameGroup = CmbNameGroup.SelectedItem as NameGroup,
                    Special = CmbSpecial.SelectedItem as Special,
                    FormTime = CmbFormTime.SelectedItem as FormTime,
                    YearAdd = CmbYear.SelectedItem as YearAdd,
                };
                OdbConnectHelper.entObj.Student.Add(stdObj);
                OdbConnectHelper.entObj.SaveChanges();
                MessageBox.Show("Студент " + stdObj.Name + " успешно добавлен", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критическая работа с приложением: " + ex.Message.ToString(),"Уведомление", MessageBoxButton.OK,MessageBoxImage.Warning);
            }

            
            FrameApp.frnObj.Navigate(new PageAddStudent());
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.GoBack();
        }

    }
}
