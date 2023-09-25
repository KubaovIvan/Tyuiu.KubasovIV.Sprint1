using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KubasovIV.Sprint1.Task3.V18.Lib;

namespace Tyuiu.KubasovIV.Sprint1.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Кубасов И. В. | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Кубасов Иван Васильевич | АСОиУБ-23-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            double a, b, c;

            Console.WriteLine("Введите значение ширины прямоугольника:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение длины прямоугольника:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение стороны квадрата:");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");      
            double roundedNumber = Math.Round(ds.HowManySquares(a, b, c), 3);
            Console.WriteLine(roundedNumber);
            Console.ReadLine();
        }
    }
}
