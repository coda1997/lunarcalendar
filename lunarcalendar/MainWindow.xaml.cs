using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
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
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
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
            PropertyChanged(this, new PropertyChangedEventArgs(nameof(CurrentDateAndTime)));
        }
        bool _isActive;
        private void Window1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isActive)
            {
                _isActive = true;
            }
            else
            {
                Application.Current.Shutdown();
            }
        }

    }
}
