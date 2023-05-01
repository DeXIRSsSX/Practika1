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
using System.Windows.Shapes;
using System.Windows.Threading;
using WpfApp3.ClassHelper;
using WpfApp3.DB;

namespace WpfApp3.Director
{
    /// <summary>
    /// Логика взаимодействия для WindowDirector.xaml
    /// </summary>
    public partial class WindowDirector : Window
    {
        public WindowDirector()
        {
            InitializeComponent();
            TxtName.Text = UserControlHelp.NameUser;
            OdbConnectHelper.entObj = new AppAcademyWSREntities();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += IzmenenieDannih;
            timer.Start();
        }
        private void IzmenenieDannih(object sender, object e)
        {
           var historyEvent = OdbConnectHelper.entObj.History.ToList();
            GridListHistory.ItemsSource = historyEvent;
            TxtTotal.Text = Convert.ToString(historyEvent.Count);

            var dateResolve = historyEvent.OrderByDescending(x => x.DateEvent).FirstOrDefault();
            TxtDate.Text = dateResolve.DateEvent.ToShortDateString();
        }
    }
}
