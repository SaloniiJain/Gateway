using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTING.CONSOLEAPP.ExtenstionClasses
{
    public static class StringOperations
    {
        /// <summary>
        /// Returning input string with uppercase characters converted to lowercase and vice versa.
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string ChangeCase(this string inputString) {
            return Char.IsLower(inputString[0]) ? inputString.ToUpper() : inputString.ToLower();
        }
        /// <summary>
        /// Converts the specified string to title case.
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string TitleCase(this string inputString)
        {
            StringBuilder updatedString = new StringBuilder();
            string[] inputStringArray = inputString.Split(' ');
            foreach(var item in inputStringArray)
            {
                bool isAcronyms = true;
                for (int index = 0; index < item.Length; index++)
                {
                    if (Char.IsLower(item[index]))
                    {
                        isAcronyms = false;
                        break;
                    }

                }
                                                                                                                    
                if (!isAcronyms)
                    updatedString.Append(CultureInfo.InvariantCulture.TextInfo.ToTitleCase(item)+" ");
                else
                    updatedString.Append(item+" ");
            }
            return updatedString.ToString().Remove(updatedString.Length-1);
        }
        /// <summary>
        /// Check characters are in lower case or not
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static bool IsLowerCase(this string inputString)
        {
            bool isLower = true;
            for (int index = 0; index < inputString.Length; index++)
            {
                if (Char.IsUpper(inputString[index]))
                {
                    isLower = false;
                    break;
                }
            }
            return isLower ? true : false;
        }
        /// <summary>
        /// Checking first character have upper case and the rest lower case
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string Capitalize(this string inputString)
        {
            return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(inputString);
        }
        /// <summary>
        /// Check characters are in upper case or not
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static bool IsUpperCase(this string inputString)
        {
            bool isUpper = true;
            for (int index = 0; index < inputString.Length; index++)
            {
                if (Char.IsLower(inputString[index]))
                {
                    isUpper = false;
                    break;
                }
            }
            return isUpper ? true : false;
        }
        /// <summary>
        /// Check input string can be converted to a valid numeric value or not.
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static bool IsValidNumericValue(this string inputString)
        {
            return int.TryParse(inputString, out int n);
        }
        /// <summary>
        /// Remove the last character from given the string
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string RemoveLastCharacter(this string inputString)
        {
            return inputString.Remove(inputString.Length - 1);
        }
        /// <summary>
        /// Count word from an input string
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static int WordCount(this string inputString)
        {
            return inputString.Split(' ').Length;
        }
        /// <summary>
        /// Converting input string into integer
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static int StringToInteger(this string inputString)
        {
            int.TryParse(inputString,out int n);
            return n;
        }
    }
}
