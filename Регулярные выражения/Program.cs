using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Регулярные_выражения
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин");
            Regex regex = new Regex("^[a-zA-Z][a-zA-Z0-9]{1,9}$");
            do
                if (regex.IsMatch(Console.ReadLine()))
                {
                    Console.WriteLine("Добро пожаловать!");
                    break;
                }
                else
                    Console.WriteLine("Вы ввели некорректный логин!\nПопробуйте ещё раз");
            while (true);
            Console.ReadKey();
        }
    }
}
