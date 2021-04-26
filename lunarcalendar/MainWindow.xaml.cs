using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace lunarcalendar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public DateTime CurrentDateAndTime { get; set; }
        private LunarCalendar lunar = new();

        public MainWindow()
        {

            InitializeComponent();
            this.DataContext = this;
            DispatcherTimer dispatcherTimer = new();
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            dispatcherTimer.Tick += new EventHandler(DisplayTime);
            dispatcherTimer.Start();
            slogan.Content = lunar.IsFriday;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void DisplayTime(object sender, EventArgs e) {
            CurrentDateAndTime = DateTime.Now;
            PropertyChanged(this, new PropertyChangedEventArgs("CurrentDateAndTime"));
        }

    }
}
