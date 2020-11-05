using AuVilator.WPF.Models;
using AuVilator.WPF.Pages;
using GalaSoft.MvvmLight.Command;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AuVilator.WPF.ViewModels
{
    public class SettingsVM : BaseVM
    {
        private SettingsM _settingsM;
        public Languages CurrentLanguage { get => _settingsM.currentLanguage; set => SetPropertyAndRaise(ref _settingsM.currentLanguage, value, "CurrentLanguage"); }
        public SettingsVM()
        {
            _settingsM = new SettingsM();
            ChangeLanguage = new RelayCommand<Languages>(l =>  SetLanguage(l));

            ExitSettings = new RelayCommand(() =>
            {
                App.Current.MainWindow.Content = new SilencerPage();
            });
        }

        public Task SetLanguage(Languages selectedLanguage)
        {
            CultureInfo cultureToAdopt;
            switch (selectedLanguage)
            {
                case Languages.English:
                    cultureToAdopt = CultureInfo.CreateSpecificCulture("en");
                    SetUICulture(cultureToAdopt);
                    break;

                case Languages.Russian:
                    cultureToAdopt = CultureInfo.CreateSpecificCulture("ru-RU");
                    SetUICulture(cultureToAdopt);
                    break;
            }
            App.Current.MainWindow.Content = new SettingsPage();
            return Task.CompletedTask;
        }

        private Task SetUICulture(CultureInfo cultureInfo)
        {
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            Properties.Settings.Default.User_Language = cultureInfo.TwoLetterISOLanguageName;
            Properties.Settings.Default.Save();
            return Task.CompletedTask;
        }

        /// <summary>
        /// Exposed command to initiate [Task] SetLanguage() from view
        /// </summary>
        public ICommand ChangeLanguage { get; private set; }

        /// <summary>
        /// Exposed command to navigate back to main page
        /// </summary>
        public ICommand ExitSettings { get; private set; }
    }
}