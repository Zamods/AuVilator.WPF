using AuVilator.WPF.Converters;
using System.ComponentModel;
using System.Globalization;

namespace AuVilator.WPF.Models
{
    public class SettingsM
    {
        public Languages currentLanguage = GetLanguage();
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
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Languages
    {
        English, 
        [Description("русский")]
        Russian
    }
}