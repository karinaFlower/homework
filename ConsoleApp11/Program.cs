using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string x ;
                x = "Гребенькова";
                Console.WriteLine($"Результат: {x}");
            }
            catch
            {
                Console.WriteLine("Возникло исключение");
            }
            finally
            {
                Console.WriteLine("finally");
            }
            Console.WriteLine("Конец данной программы");
            Console.Read();
        }
    }
}
