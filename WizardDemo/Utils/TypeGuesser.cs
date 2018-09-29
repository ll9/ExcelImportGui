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
            var uniqueItems = new HashSet<string>(column);

            // return Stringtype if Column is empty
            if (uniqueItems.Count == 1 && string.IsNullOrEmpty(uniqueItems.First()))
            {
                return DataType.System_String;
            }


            foreach (var typeToCheck in Enum.GetValues(typeof(DataType)).Cast<DataType>())
            {
                var i = 0;
                foreach (var stringToGuess in uniqueItems)
                {
                    var guessedType = GuessTpe(stringToGuess);

                    // Check if type to check is not compatible to guessedTpe
                    if (!guessedType.HasFlag(typeToCheck))
                    {
                        break;
                    }
                    i++;
                }

                if (i == uniqueItems.Count)
                {
                    return typeToCheck;
                }
            }

            return DataType.System_String;

        }

        public static DataType GuessTpe(string item)
        {

            bool boolValue;
            Int32 intValue;
            Int64 bigintValue;
            double doubleValue;
            DateTime dateValue;

            // Place checks higher in if-else statement to give higher priority to type.

            if (string.IsNullOrEmpty(item)) return DataType.ANY;

            if (bool.TryParse(item, out boolValue))
                return DataType.System_Boolean;
            else if (Int32.TryParse(item, out intValue))
                return (DataType.System_Int32 | DataType.System_Int64 | DataType.System_Double);
            else if (Int64.TryParse(item, out bigintValue))
                return (DataType.System_Int64 | DataType.System_Double);
            else if (double.TryParse(item, out doubleValue))
                return DataType.System_Double;
            else if (DateTime.TryParse(item, out dateValue))
                return DataType.System_DateTime;
            else return DataType.System_String;

        }
    }
}
