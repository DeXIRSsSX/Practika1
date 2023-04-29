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
    /// Логика взаимодействия для EditEvaluation.xaml
    /// </summary>
    public partial class EditEvaluation : Page
    {
        public EditEvaluation()
        {
            InitializeComponent();
            CmbSelectGroup.DisplayMemberPath = "Name";
            CmbSelectGroup.SelectedValuePath = "id";
            CmbSelectGroup.ItemsSource = OdbConnectHelper.entObj.NameGroup.ToList();
        }
        /// <summary>
        /// Логика данных по работе с редактированием оценок студентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditEvaluation_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.Navigate(new PageEditEvaluationStudent((sender as Button).DataContext as Student));
        }

        private void CmbSelectGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectGroup = Convert.ToInt32(CmbSelectGroup.SelectedValue);
            ListStudent.ItemsSource = OdbConnectHelper.entObj.Student.Where(x => x.IdNameGroup == SelectGroup).ToList();
           CmbSelectGroup.SelectedIndex = 0;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.GoBack();
        }
    }
}
