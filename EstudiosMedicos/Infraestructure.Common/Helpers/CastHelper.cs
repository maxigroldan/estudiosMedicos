using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Common.Helpers
{
    public class CastHelper
    {
        public static bool GetBoolFromString(string value)
        {
            if (bool.TryParse(value, out var enable))
            {
                return enable;
            }
            return value == "1";
        }

        public static T GetFromString<T>(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return Activator.CreateInstance<T>();
            }
            if (typeof(T) == typeof(bool))
            {
                return (T)Convert.ChangeType(GetBoolFromString(value), typeof(T));
            }

            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}
