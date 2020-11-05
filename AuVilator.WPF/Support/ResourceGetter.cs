using AuVilator.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace AuVilator.WPF.Support
{
    public class ResourceGetter : BaseVM
    {
        private ResourceManager _RM { get; set; }

        public ResourceGetter(CultureInfo currentCulture)
        {
            _RM = new ResourceManager("AuVilator.WPF.Properties.Resources", Assembly.GetExecutingAssembly());
        }

        public string GetSpecifiedResource(string name)
        {
            try
            {
               return _RM.GetString(name);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

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
