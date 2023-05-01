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
    /// Логика взаимодействия для DeleteStudent.xaml
    /// </summary>
    public partial class DeleteStudent : Page
    {
        public DeleteStudent()
        {
            InitializeComponent();
            CmbSlectGroup.SelectedValuePath = "id";
            CmbSlectGroup.DisplayMemberPath = "Name";
            CmbSlectGroup.ItemsSource = OdbConnectHelper.entObj.NameGroup.ToList();

            GridList.ItemsSource = OdbConnectHelper.entObj.Student.ToList();
        }

        private void CmbSlectGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectGroupStudent = Convert.ToInt32(CmbSlectGroup.SelectedValue);
            GridList.ItemsSource = OdbConnectHelper.entObj.Student.Where(x => x.IdNameGroup == SelectGroupStudent).ToList();
        }

        private void BtnDeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(GridList.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < GridList.SelectedItems.Count; i++)
                    {
                        Student studentObj = GridList.SelectedItems[i] as Student;
                        OdbConnectHelper.entObj.Student.Remove(studentObj);
                    }
                    OdbConnectHelper.entObj.SaveChanges();
                    MessageBox.Show("Данные о студенте удалены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    GridList.ItemsSource = OdbConnectHelper.entObj.Student.ToList();
                }     
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:" + ex.Message.ToString(), "Крит урон по работе", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.GoBack();   
        }
    }
}
