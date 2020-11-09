using AuVilator.WPF.Converters;
using System.ComponentModel;
using System.Globalization;

namespace AuVilator.WPF.Models
{
    /// <summary>
    /// Main class that holds all application related settings.
    /// </summary>
    public class SettingsM
    {
        /// <summary>
        /// Tells the current language of the application.
        /// </summary>
        public Languages currentLanguage = GetLanguage();
        /// <summary>
        /// Acquires the current language of the application through looking into current culture.
        /// </summary>
        /// <returns>Current language of the application.</returns>
        private static Languages GetLanguage()
        {
            CultureInfo currentCulture = CultureInfo.CurrentUICulture;
            string cultureName = currentCulture.TwoLetterISOLanguageName;
            Languages language;
            switch (cultureName)
            {
                case "en":
                default:
                    language = Languages.English;
                    break;

                case "ru":
                    language = Languages.Russian;
                    break;
            }
            return language;
        }
    }
    /// <summary>
    /// Represents the all available languages in the application.
    /// </summary>
    /// <remarks>
    /// Used for UI display and easy language selection.
    /// </remarks>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Languages
    {
        /// <summary>
        /// Represents the English language regardless of region.
        /// </summary>
        English,
        /// <summary>
        /// Represents the Russian language regardless of region.
        /// </summary>
        /// <remarks>
        /// UI will display "русский" not "Russian".
        /// </remarks>
        [Description("русский")]
        Russian
    }
}