using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace AuVilator.WPF.Controls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class NavPageBarControl : UserControl
    {
        public NavPageBarControl()
        {
            InitializeComponent();
            /// default values
            this.BackNavBtnVisibility = this.NextNavBtnVisibility = Visibility.Collapsed;
        }
        /// <summary>
        /// Dependency property for [NavBarTitle]
        /// </summary>
        public static readonly DependencyProperty NavBarTextBlockProperty =
         DependencyProperty.Register("NavBarTitle", typeof(string), typeof(NavPageBarControl), null);

        /// <summary>
        /// Title that shows up in navigation bar.
        /// </summary>
        public string NavBarTitle
        {
            get { return (string)GetValue(NavBarTextBlockProperty); }
            set { SetValue(NavBarTextBlockProperty, value); }
        }
        /// <summary>
        /// Dependency property for [BackNavBtnVisibility]
        /// </summary>
        public static readonly DependencyProperty BackNavBtnVisibilityProperty =
        DependencyProperty.Register("BackNavBtnVisibility", typeof(Visibility), typeof(NavPageBarControl), null);
        /// <summary>
        /// Visibility of back button in navigation bar.
        /// </summary>
        /// <remarks>Default value is set to 'Collapsed'</remarks>
        public Visibility BackNavBtnVisibility
        {
            get { return (Visibility)GetValue(BackNavBtnVisibilityProperty); }
            set { SetValue(BackNavBtnVisibilityProperty, value); }
        }
        /// <summary>
        /// Dependency property for [NextNavBtnVisibility]
        /// </summary>
        public static readonly DependencyProperty NextNavBtnVisibilityProperty =
        DependencyProperty.Register("NextNavBtnVisibility", typeof(Visibility), typeof(NavPageBarControl), null);
        /// <summary>
        /// Visibility of next button in navigation bar.
        /// </summary>
        /// <remarks>Default value is set to 'Collapsed'</remarks>
        public Visibility NextNavBtnVisibility
        {
            get { return (Visibility)GetValue(NextNavBtnVisibilityProperty); }
            set { SetValue(NextNavBtnVisibilityProperty, value); }
        }
        /// <summary>
        /// Dependency property for [NextNavBtnCommand]
        /// </summary>
        public static readonly DependencyProperty NextNavBtnCommandProperty =
        DependencyProperty.Register("NextNavBtnCommand", typeof(ICommand), typeof(NavPageBarControl), null);
        /// <summary>
        /// Command for next navigation button available for binding.
        /// </summary>
        public ICommand NextNavBtnCommand
        {
            get { return (ICommand)GetValue(NextNavBtnCommandProperty); }
            set { SetValue(NextNavBtnCommandProperty, value); }
        }
        /// <summary>
        /// Dependency property for [BackNavBtnCommand]
        /// </summary>
        public static readonly DependencyProperty BackNavBtnCommandProperty =
        DependencyProperty.Register("BackNavBtnCommand", typeof(ICommand), typeof(NavPageBarControl), null);
        /// <summary>
        /// Command for back navigation button available for binding.
        /// </summary>
        public ICommand BackNavBtnCommand
        {
            get { return (ICommand)GetValue(BackNavBtnCommandProperty); }
            set { SetValue(BackNavBtnCommandProperty, value); }
        }
    }
}
