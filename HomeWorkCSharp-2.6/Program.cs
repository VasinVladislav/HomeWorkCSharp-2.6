using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.6. Дан радиус окружности. Найти длину окружности и площадь круга.
            Console.WriteLine("Программа для нахождения длины окружности и площади круга.");
        input:
            Console.Write("Введите значение радиуса окружности \"r\": ");
            double r = Convert.ToDouble(Console.ReadLine());
            while (!(r > 0))
            {
                Console.WriteLine("Введено неверное значение");
                goto input;               
            }
            double d = 2 * r;   //Диамерт через радиус
            double C = Math.PI * d;  //Длина окружности через диаметр
            double S = Math.PI * Math.Pow(r, 2);    //Площадь круга
            Console.WriteLine($"Длина окружности равна {C.ToString("#.##")}\nПлощадь круга равна {S.ToString("#.##")}");
        }
    }
}
