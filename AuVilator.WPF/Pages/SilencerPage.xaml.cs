using AuVilator.Library.Features.Support;
using AuVilator.WPF.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AuVilator.WPF.Pages
{
    /// <summary>
    /// Interaction logic for SilencerPage.xaml
    /// </summary>
    public partial class SilencerPage : Page
    {
        public SilencerPage()
        {
            InitializeComponent();
            var VM = new SilencerVM();
            this.DataContext = VM;
            VM.ProgessIndicator = new Progress<SilencerProgressModel>();
            VM.ProgessIndicator.ProgressChanged += SilencerProgress;
        }

        private void SilencerProgress(object sender, SilencerProgressModel e)
        {
            this.progressBar.Value = e.CompletionPercentage;
            this.progressText.Text = e.ProgressMessage;
        }

        private void AmpPosSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var silder = (Slider)sender;
            var value = 0.0;
            bool isDouble = Double.TryParse(silder.Value.ToString(), out value);
            if (isDouble == true)
            {
                ampStartPosTextBox.BorderBrush = null;
                ampStartPosTextBoxError.Visibility = Visibility.Hidden;
            }
            else
            {
                ampStartPosTextBox.BorderBrush = new SolidColorBrush(Colors.Red);
                ampStartPosTextBoxError.Text = $"Alphabetics {silder.Value} are not allowed! \nMust be numerical value only!";
                ampStartPosTextBoxError.Visibility = Visibility.Visible;
            }
        }

        private void FileSelectionInformationButtonClicked(object sender, RoutedEventArgs e)
        {
            var controlVisibility = this.fileSelectInformationSP.Visibility;
            if (controlVisibility == Visibility.Visible)
            {
                this.fileSelectInformationSP.Visibility = Visibility.Hidden;
            }
            else
            {
                this.fileSelectInformationSP.Visibility = Visibility.Visible;
            }
        }

        private void BinSizeSelectionInformationButtonClicked(object sender, RoutedEventArgs e)
        {
            var controlVisibility = this.binSizeSelectionInformationSP.Visibility;
            if (controlVisibility == Visibility.Visible)
            {
                this.binSizeSelectionInformationSP.Visibility = Visibility.Hidden;
            }
            else
            {
                this.binSizeSelectionInformationSP.Visibility = Visibility.Visible;
            }
        }

        private void StartAmpPosInformationButtonClicked(object sender, RoutedEventArgs e)
        {
            var controlVisibility = this.startAmpPosInformationSP.Visibility;
            if (controlVisibility == Visibility.Visible)
            {
                this.startAmpPosInformationSP.Visibility = Visibility.Hidden;
            }
            else
            {
                this.startAmpPosInformationSP.Visibility = Visibility.Visible;
            }
        }

        private void EndAmpPosInformationButtonClicked(object sender, RoutedEventArgs e)
        {
            var controlVisibility = this.endAmpPosInformationSP.Visibility;
            if (controlVisibility == Visibility.Visible)
            {
                this.endAmpPosInformationSP.Visibility = Visibility.Hidden;
            }
            else
            {
                this.endAmpPosInformationSP.Visibility = Visibility.Visible;
            }
        }

    }
}