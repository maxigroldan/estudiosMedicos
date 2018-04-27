using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Infraestructure.Data
{
    class ConverterVarBinaryToByteArray
    {
        private readonly string propertyName;

        internal ConverterVarBinaryToByteArray(string propertyName)
        {
            this.propertyName = propertyName;
        }

        internal byte[] Convert(IDataRecord dataRecord)
        {
            return (byte[])dataRecord.GetValue(dataRecord.GetOrdinal(propertyName));
        }
    }
}
