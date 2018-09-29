using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardDemo.Models;

namespace WizardDemo.Utils
{
    public class TypeGuesser
    {
        public static DataType GuessType(List<string> column)
        {
            //TODO: implement
            return DataType.System_String;
        }

        public static DataType GuessTpe(string item)
        {
            private static DataType GuessType(string str)
            {

                bool boolValue;
                Int32 intValue;
                Int64 bigintValue;
                double doubleValue;
                DateTime dateValue;

                // Place checks higher in if-else statement to give higher priority to type.

                if (bool.TryParse(str, out boolValue))
                    return DataType.System_Boolean;
                else if (Int32.TryParse(str, out intValue))
                    return DataType.System_Int32;
                else if (Int64.TryParse(str, out bigintValue))
                    return DataType.System_Int64;
                else if (double.TryParse(str, out doubleValue))
                    return DataType.System_Double;
                else if (DateTime.TryParse(str, out dateValue))
                    return DataType.System_DateTime;
                else return DataType.System_String;

            }
        }
    }
}
