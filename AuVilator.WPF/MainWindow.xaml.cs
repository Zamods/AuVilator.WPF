using System;
using System.Globalization;
using System.Threading;
using System.Windows;

namespace AuVilator.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public override void BeginInit()
        {
            base.BeginInit();
            // Sets the pre saved laugauge for user
            CultureInfo newCulture = CultureInfo.CreateSpecificCulture(Properties.Settings.Default.User_Language);
            Thread.CurrentThread.CurrentUICulture = newCulture;
        }
    }
}