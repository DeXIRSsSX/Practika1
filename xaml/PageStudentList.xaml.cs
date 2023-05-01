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
using WpfApp3.Teacher;

namespace WpfApp3.xaml
{
    /// <summary>
    /// Логика взаимодействия для PageStudentList.xaml
    /// </summary>
    public partial class PageStudentList : Page
    {
        public PageStudentList()
        {
            InitializeComponent();

            CmbSlectGroup.SelectedValuePath = "id";
            CmbSlectGroup.DisplayMemberPath = "Name";
            CmbSlectGroup.ItemsSource = OdbConnectHelper.entObj.NameGroup.ToList();

            GridList.ItemsSource = OdbConnectHelper.entObj.Student.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.GoBack();   
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            int SelectGroup = Convert.ToInt32(CmbSlectGroup.SelectedValue);
            GridList.ItemsSource = OdbConnectHelper.entObj.Student.Where(x => x.IdNameGroup == SelectGroup).ToList();
            GridList.SelectedIndex = 0;
        }

        private void BtnProfile_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.Navigate(new PageJournalStudent((sender as Button).DataContext as Student));
        }

        private void CmbSlectGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectGroup = Convert.ToInt32(CmbSlectGroup.SelectedValue);
            GridList.ItemsSource = OdbConnectHelper.entObj.Student.Where(x => x.IdNameGroup == SelectGroup).ToList();
            GridList.SelectedIndex = 0;
        }
    }
}
