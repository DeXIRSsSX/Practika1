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
using WpfApp3.ClassHelper;
using WpfApp3.DB;
using WpfApp3.Teacher;

namespace WpfApp3.xaml
{
    /// <summary>
    /// Логика взаимодействия для PageStudent.xaml
    /// </summary>
    public partial class PageStudent : Page
    {
        public PageStudent()
        {
            InitializeComponent();
            TxtLoginUser.Text = UserControlHelp.LoginUser;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.GoBack();
        }

        private void BtnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
