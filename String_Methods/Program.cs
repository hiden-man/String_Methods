using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String_Methods();
        }
        static void String_Methods()
        {
            string someText1 = "Some text";
            Console.WriteLine(someText1);
            Console.WriteLine(someText1.ToUpper()); // переводить текст у верхній регістр
            Console.WriteLine(someText1.ToLower()); // переводить текст у нижній регістр
            Console.WriteLine(someText1.Replace(" ", "_")); // заміняє перший символ в тексті на другий
            Console.WriteLine(someText1.Length); // виводить кількість символів у тексті
            Console.WriteLine(someText1.Insert(4," the")); // Вставляє вказаний текст у вказане місце в тексті
            Console.WriteLine(someText1.Substring(5,4)); // Виводить вказаний відрізок тексту 

        }
    }
}
