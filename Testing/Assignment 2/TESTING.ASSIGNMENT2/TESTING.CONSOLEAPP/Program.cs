using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTING.CONSOLEAPP.ExtenstionClasses;

namespace TESTING.CONSOLEAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saloni".ChangeCase());
            Console.WriteLine("saloni CSE KAJAL Bca BbA".TitleCase());
            Console.WriteLine("john".IsLowerCase()?"All Characters are lower":"Not all characters are lower");
            Console.WriteLine("saloni".Capitalize());
            Console.WriteLine("ram".IsUpperCase() ? "All Characters are upper" : "Not all characters are upper");
            Console.WriteLine("123d".IsValidNumericValue()?"Is valid numeric string":"Is not valid numeric string");
            Console.WriteLine("Kajal Singhvi".RemoveLastCharacter());
            Console.WriteLine("Saloni Jain".WordCount());
            Console.WriteLine("123".StringToInteger());
            Console.ReadLine();
        }
    }
}
