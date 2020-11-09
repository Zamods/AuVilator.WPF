using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace AuVilator.WPF.Support
{
    /// <summary>
    /// Important class that allows to retrieve localized strings based on respective culture.
    /// </summary>
    public class ResourceGetter
    {
        private ResourceManager _RM { get; set; }

        /// <summary>
        /// Initializes the [ResourceManager] with given culture to use localized string.
        /// </summary>
        /// <param name="currentCulture">Current culture and default is [Neutral] culture.</param>
        public ResourceGetter(CultureInfo currentCulture)
        {
            _RM = new ResourceManager("AuVilator.WPF.Properties.Resources", Assembly.GetExecutingAssembly());
        }
        /// <summary>
        /// Provides a way to acquire localized string from resource file based on initialized culture.
        /// </summary>
        /// <param name="name">Key of the resource string.</param>
        /// <returns>Localized string for respective culture.</returns>
        /// <exception cref="Exception">
        /// Throws when localized can't be acquired due to wrong key, non existent culture or non existent resource file.
        /// </exception>
        public string GetSpecifiedResource(string name)
        {
            try
            {
                return _RM.GetString(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Provides a way to acquire localized string from resource file based on explicit culture.
        /// </summary>
        /// <param name="name">>Key of the resource string.</param>
        /// <param name="currentCulture">The culture for intented string is requested.</param>
        /// <returns>Localized string for respective culture.</returns>
        /// <exception cref="Exception">Throws when localized can't be acquired due to wrong key, non existent culture or non existent resource file.</exception>
        public string GetSpecifiedResource(string name, CultureInfo currentCulture)
        {
            try
            {
                return _RM.GetString(name, currentCulture);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}