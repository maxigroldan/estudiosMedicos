using System;
using System.Reflection;
using System.Collections.Generic;
using Infraestructure.Core;
using Infraestructure.Common.Extensions;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Linq;

namespace Infraestructure.Data
{
    public class BaseMapper<T> where T : BaseEntity, new()
    {
        public IRowMapper<T> RowMapper => CreateRowMapper();

        private IRowMapper<T> CreateRowMapper()
        {
            var aux = MapBuilder<T>.MapAllProperties();

            foreach (var property in typeof(T).GetProperties())
            {
                /*if (property.GetCustomAttribute(typeof(NotMappedAttribute), false) != null)
                {
                    aux.DoNotMap(property);
                }
                else
                {*/
                    var type = property.PropertyType;
                    if (type.IsEnum)
                    {
                        MapEnum(aux, type, property);
                    }
                    else if (type.IsNullableEnum())
                    {
                        MapEnum(aux, type.GetNulleableType(), property);
                    }
                    else
                    {
                        if (!property.CanWrite)
                        {
                            continue;
                        }
                        if (property.PropertyType == typeof(byte[]))
                        {
                            var converter = new ConverterVarBinaryToByteArray(property.Name);
                            aux.Map(property)
                                .WithFunc(converter.Convert);
                        }
                    }
                //}
            }

            return aux.Build();
        }

        private void MapEnum(IMapBuilderContext<T> aux, Type type, PropertyInfo property)
        {
            aux.Map(property).WithFunc(
                rec => rec.IsDBNull(rec.GetOrdinal(property.Name))
                    ? null
                    : Enum.ToObject(type, rec.GetInt32(rec.GetOrdinal(property.Name)))
            );
        }
        public IMapBuilderContext<T> MapBuilderContext => MapBuilder<T>.MapAllProperties();

        public IEnumerable<PropertyInfo> GetMappedProperties()
        {
            return
                typeof(T).GetProperties()
                    /*.Where(
                        property =>
                            !property.IsDefined(typeof(NotMappedAttribute), false) &&
                            !property.IsDefined(typeof(DatabaseGeneratedAttribute), false))*/
                    .ToList();
        }
    }
}