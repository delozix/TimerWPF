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
using System.Windows.Threading;

namespace Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DateTime myDate;
        public MainWindow()
        {
            InitializeComponent();
            startclock();
        }
        public void startclock()
        {
            myDate = new DateTime(2023, 3, 30, 0, 0, 0);
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();
        }

        private void tickevent(object? sender, EventArgs e)
        {
            myDate = myDate.AddSeconds(1);
            Dispatcher.Invoke(() =>
            {
                datelb.Text = myDate.ToString(@"T");
            });
        }
    }
}
