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
using WpfApp3.MVC;
using WpfApp3.Teacher;

namespace WpfApp3.xaml
{
    /// <summary>
    /// Логика взаимодействия для PageTeacher.xaml
    /// </summary>
    public partial class PageTeacher : Page
    {
        public PageTeacher()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.GoBack();
        }

        private void BtnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.Navigate(new PageAddStudent());
        }

        private void BtnAddEvaluation_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.Navigate(new PageAddEvaluation());
        }

        private void StudentList_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.Navigate(new PageStudentList());
        }

        private void EditEvaluation_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.Navigate(new EditEvaluation());
        }

        private void DeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.Navigate(new DeleteStudent());   
        }

      

        private void BtnMVC_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.Navigate(new PageMVC());
        }
    }
}
