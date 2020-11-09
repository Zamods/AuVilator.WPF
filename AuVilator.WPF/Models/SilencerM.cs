namespace AuVilator.WPF.Models
{
    /// <summary>
    /// Class that holds all properties for silencing the audio.
    /// </summary>
    /// <remarks>
    /// Data model of this class is dependent on [AuVilator.Library.Features.Silencer] which does all the work.
    /// </remarks>
    public class SilencerM
    {
        /// <summary>
        /// Represents the search amplitude value that is used in normal loop to find starting point of non-silent audio signal.
        /// </summary>
        /// <remarks>
        /// Default value is set to [5.0] which co-relates with [binsize].
        /// </remarks>
        public double startPositionAmplitude = 5.0;
        /// <summary>
        /// Represents the search amplitude value that is used in reversed loop to find ending point of non-silent audio signal.
        /// </summary>
        /// <remarks>
        /// Default value is set to [7.1] which co-relates with [binsize].
        /// </remarks>
        public double endPositionAmplitude = 7.1;
        /// <summary>
        /// Represents the size of the number of samples that will be processed at the time.
        /// </summary>
        /// <remarks>
        /// Default value is set to [2048].
        /// Attention: Keep in mind that this is also the size of FFT calculation and larger the size will get then computation will increase too.
        /// </remarks>
        public int binSize = 2048;
        /// <summary>
        /// Selected input name of the file.
        /// </summary>
        /// <remarks>
        /// Primary just used for UX.
        /// </remarks>
        public string selectedFileName;
        /// <summary>
        /// Selected input path of the file.
        /// </summary>
        public string selectedFilePath;
        /// <summary>
        /// Selected output name of the file.
        /// </summary>
        /// <remarks>
        /// Primary just used for UX.
        /// </remarks>
        public string selectedOutputFileName;
        /// <summary>
        /// Selected output path of the file.
        /// </summary>
        public string selectedOutputFilePath;
    }
}