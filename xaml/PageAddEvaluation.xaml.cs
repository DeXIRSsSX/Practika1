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
    /// Логика взаимодействия для PageAddEvaluation.xaml
    /// </summary>
    public partial class PageAddEvaluation : Page
    {
        public PageAddEvaluation()
        {
            InitializeComponent();
            CmbDiscipline.SelectedValuePath = "Id";
            CmbDiscipline.DisplayMemberPath = "Name";
            CmbDiscipline.ItemsSource = OdbConnectHelper.entObj.Discipline.ToList();

            CmbNameStudent.SelectedValuePath = "Id";
            CmbNameStudent.DisplayMemberPath = "Name";

            CmbGroup.SelectedValuePath = "Id";  
            CmbGroup.DisplayMemberPath= "Name"; 
            CmbGroup.ItemsSource = OdbConnectHelper.entObj.NameGroup.ToList();
        }

        private void BtnAddEvaluation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Journal jourObj = new Journal()
                {
                    Student = CmbNameStudent.SelectedItem as Student,
                    Evaluation = Convert.ToInt32(TxbEvaluation.Text).ToString(),
                    Discipline = CmbDiscipline.SelectedItem as Discipline,
                    NameGroup = CmbGroup.SelectedItem as NameGroup,
                };
                OdbConnectHelper.entObj.Journal.Add(jourObj);
                OdbConnectHelper.entObj.SaveChanges();
                MessageBox.Show("Оценка успешно поставлена!" , "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                FrameApp.frnObj.GoBack(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критическая работа с приложением: " + ex.Message.ToString(), "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void CmbGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelecteGroup = Convert.ToInt32(CmbGroup.SelectedValue);
            CmbNameStudent.ItemsSource = OdbConnectHelper.entObj.Student.Where (x => x.IdNameGroup == SelecteGroup).ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.GoBack();   
        }

        private void TxbEvaluation_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "2345".IndexOf(e.Text) < 0;
        }
    }
}
