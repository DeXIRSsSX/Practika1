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

namespace WpfApp3.Teacher
{
    /// <summary>
    /// Логика взаимодействия для PageEditEvaluationStudent.xaml
    /// </summary>
    public partial class PageEditEvaluationStudent : Page
    {
        private string NameStudent;
        private int StudentId;
        public PageEditEvaluationStudent(Student student)
        {
            InitializeComponent();
            TxtName.Text = student.Name;
            NameStudent = student.Name;
            StudentId = student.id;
            ListJoutnal.ItemsSource = OdbConnectHelper.entObj.Journal.Where(x => x.IdStudent == student.id).ToList();
            ListJoutnal.SelectedIndex = 0;
            ListJoutnal.Columns[0].IsReadOnly = true;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            
            OdbConnectHelper.entObj.SaveChanges();
            MessageBox.Show("Данные успешно изменены у студента -" + NameStudent + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.GoBack();
        }
    }
}
