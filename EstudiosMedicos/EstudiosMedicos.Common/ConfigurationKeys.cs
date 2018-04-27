using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudiosMedicos.Common
{
    public class ConfigurationKeys
    {
        public static bool IsDeploy => Infraestructure.Common.Helpers.ConfigurationHelper.GetAppSettings<bool>(ConfigurationRes.Deploy);
    }
}
