using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KubasovIV.Sprint1.Task7.V13.Lib;
namespace Tyuiu.KubasovIV.Sprint1.Task7.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Кубасов И. В. | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Кубасов Иван Васильевич | АСОиУБ-23-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу,                                                     *");
            Console.WriteLine("* которая вычисляет математическое выражение по исходным значениям данных,*");
            Console.WriteLine("* вводимых пользователем. Ответ округлите до 3 знаков после запятой.      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("     y^2 - cos(x^2) + 10 ");
            Console.WriteLine("z = ---------------------");
            Console.WriteLine("     x^2 - sin(y^2) + 12 ");

            double x, y;

            Console.WriteLine("Введите значение переменной x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной y:");
            y = Convert.ToDouble(Console.ReadLine());

            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("z = " + ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}
