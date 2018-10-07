using System;
using System.Collections.Generic;

namespace WizardDemo.Models
{
    public enum DataType
    {
        System_Boolean = 1,
        System_Int32 = 2,
        System_Int64 = 4,
        System_Double = 8,
        System_DateTime = 16,
        System_String = 32,

        LongOrDouble = (System_Int64 | System_Double),
        Numeric = (System_Int32 | System_Int64 | System_Double),
        ANY = (System_Boolean | System_Int32 | System_Int64 | System_Double | System_DateTime | System_String)
    }

    public static class DataTypeExtension
    {
        public static string GetSqlDataType(this DataType dataType)
        {
            switch (dataType)
            {
                case (DataType.System_Boolean):
                    return "INTEGER";
                case (DataType.System_DateTime):
                    return "TEXT";
                case (DataType.System_Double):
                    return "DOUBLE";
                case (DataType.System_Int32):
                    return "int32";
                case (DataType.System_Int64):
                    return "int64";
                case (DataType.System_String):
                    return "VARCHAR(60)";
                default:
                    return "VARCHAR(60)";
            }
        }

        public static dynamic GetDynamicValue(this DataType dataType, string value)
        {
            switch (dataType)
            {
                case (DataType.System_Boolean):
                    return bool.TryParse(value, out var boolVal) ? boolVal : (bool?)null;
                case (DataType.System_DateTime):
                    return DateTime.TryParse(value, out var dateTimeVal) ? dateTimeVal : (DateTime?)null;
                case (DataType.System_Double):
                    return double.TryParse(value, out var doubleVal) ? doubleVal : (double?)null;
                case (DataType.System_Int32):
                    return int.TryParse(value, out var intVal) ? intVal : (int?)null;
                case (DataType.System_Int64):
                    return long.TryParse(value, out var longVal) ? longVal : (long?)null;
                case (DataType.System_String):
                    return value;
                default:
                    return value;
            }
        }

        public static Type DataTypeToType(this DataType dataType)
        {
            switch (dataType)
            {
                case (DataType.System_Boolean):
                    return typeof(bool);
                case (DataType.System_DateTime):
                    return typeof(DateTime);
                case (DataType.System_Double):
                    return typeof(double);
                case (DataType.System_Int32):
                    return typeof(int);
                case (DataType.System_Int64):
                    return typeof(long);
                case (DataType.System_String):
                    return typeof(string);
                default:
                    return typeof(string);
            }
        }

        public static DataType TypeToDataType(Type type)
        {
            var @switch = new Dictionary<Type, DataType> {
                { typeof(bool), DataType.System_Boolean },
                { typeof(DateTime), DataType.System_DateTime },
                { typeof(double), DataType.System_Double },
                { typeof(int), DataType.System_Int32 },
                { typeof(long), DataType.System_Int64 },
                { typeof(string), DataType.System_String }
            };

            return @switch[type];
        }
    }
}
