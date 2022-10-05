using System;
class Program
{
    public static void Main(string[] args)
    {
        //расчет первого сегмента графика.
        static double segment1(double x)
        {
            // Характеристика наклона(k) и пересичения(b).
            double b = -3;
            double k = 0;
            double y;
            // По уравнению прямой.
            y = (k * x) + b;
            // Возвращаем значение в нижней четверти
            return -y;
        }

        //расчет второго сегмента графика.
        static double segment2(double x)
        {
            // Характеристика наклона(k) и пересичения(b).
            double b = 6;
            double k = 2;
            double y;
            // По уравнению прямой.
            y = (k * x) + b;
            // Возвращаем значение в нижней четверти
            return -y;
        }

        //расчет третьего сегмента графика.
        static double segment3(double x, double r)
        {
            double y;
            //по уравнению окружности
            y = Math.Sqrt((r * r) - (x * x));
            //возвращаем значение в нижней четверти
            return -y;
        }

        //расчет четвёртого сегмента графика.
        static double segment4(double x)
        {
            // Характеристика наклона(k) и пересичения(b).
            double b = -9 / 5;
            double k = 3;
            double y;
            // По уравнению прямой.
            y = (k * x) + b;
            // Возвращаем значение в нижней четверти
            return -y;
        }

        //расчет пятого сегмента графика.
        static double segment5(double x)
        {
            // Характеристика наклона(k) и пересичения(b).
            double b = 3;
            double k = 0;
            double y;
            // По уравнению прямой.
            y = (k * x) + b;
            // Возвращаем значение в нижней четверти
            return -y;
        }

        Console.Write("Введите радиус R: ");
        string R = Console.ReadLine();
        double r = double.Parse(R);

        Console.Write("Введите значения X: ");
        for (double x = double.Parse(Console.ReadLine()); x <= 11; x += 0.2)
        {
            if (x < -8 )
            {
                Console.WriteLine("Функция не определена");
            }

            else if (x < -4)
            {
                Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x));
            }

            else if (x < -3)
            {
                Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment2(x));
            }
            else if (x < 3 && r < 3)
            {
                Console.WriteLine("функции появляются разрывы второго рода,и она не определена");
            }
            else if (x < 3 && r > 3)
            {
                Console.WriteLine("дуга окружности ограничена в исходных пределах");
            }

            else if (x < 3 && r == 3)
            {
                Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment3(x, r));
            }

            else if (x < 8)
            {
                Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment4(x));
            }

            else if (x < 10)
            {
                Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment5(x));
            }

            else
            {
                Console.WriteLine("Функция не определена");
            }
        }

        
    }
}



