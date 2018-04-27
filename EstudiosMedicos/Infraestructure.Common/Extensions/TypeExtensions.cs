using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Common.Extensions
{
    public static class TypeExtensions
    {
        public static bool IsNullableEnum(this Type t)
        {
            var u = Nullable.GetUnderlyingType(t);
            return u != null && u.IsEnum;
        }

        public static Type GetNulleableType(this Type t)
        {
            return Nullable.GetUnderlyingType(t);
        }
    }
}
