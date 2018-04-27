using System;
using System.Configuration;

namespace Infraestructure.Common.Helpers
{
    public class ConfigurationHelper
    {
        public static string GetConnectionString(string connName)
        {
            return ConfigurationManager.ConnectionStrings[connName].ToString();
        }

        public static T GetAppSettings<T>(string appKey)
        {
            return CastHelper.GetFromString<T>(ConfigurationManager.AppSettings[appKey]);
        }
    }
}
