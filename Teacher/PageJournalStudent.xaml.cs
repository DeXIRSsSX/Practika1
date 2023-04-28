﻿using System;
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
    /// Логика взаимодействия для PageJournalStudent.xaml
    /// </summary>
    public partial class PageJournalStudent : Page
    {
        public PageJournalStudent(Student student)
        {
            InitializeComponent();
            TxtName.Text = student.Name;
            ListJoutnal.ItemsSource = OdbConnectHelper.entObj.Journal.Where(x => x.IdStudent == student.id).ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.GoBack(); 
        }

        private void BtnPrint_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printObj = new PrintDialog();
            if (printObj.ShowDialog() == true)
            {
                printObj.PrintVisual(DataPrint, "");
            }
            else
            {
                MessageBox.Show("Пользователь прирвал печать", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
    }
}
