using System;

namespace Practic
{
    class Practic
    {
        static void FirstTask()
        {
            Console.Write("y = 7x^2 - 3x + 4 введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = (7 * Math.Pow(x, 2)) - (3 * x) + 4;
            Console.Write("y = ");
            Console.WriteLine(y);
            Console.ReadLine();
        }
        static void SecondTask()
        {
            Console.Write("Введите радиус: ");
            double R = Convert.ToDouble(Console.ReadLine());
            double P = 2 * Math.PI * R;
            double S = Math.PI * Math.Pow(R, 2);
            Console.Write("Длинна окружности: ");
            Console.WriteLine(P);
            Console.Write("Площадь круга: ");
            Console.WriteLine(S);
            Console.ReadLine();
        }
        static void ThirdTask()
        {
            Console.Write("Введите расстояние в сантиметрах: ");
            int DistanceInSm = Convert.ToInt32(Console.ReadLine());
            int DistanceInMeter = DistanceInSm / 100;
            Console.Write("Полных метров: ");
            Console.WriteLine(DistanceInMeter);
            Console.ReadLine();
        }
        static void FourthTask()
        {
            int days = 234;
            int weeks = days / 7;
            Console.Write("Прошло полных недель: ");
            Console.WriteLine(weeks);
            Console.ReadLine();
        }
        static void FifthTask()
        {
            Console.Write("Введите двузначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = (number / 10) + (number % 10);
            int product = (number / 10) * (number % 10);
            int numberOfUnits = number % 10;
            int numberOfTens = (number / 10) % 10;
            Console.Write("Сумма его чисел: ");
            Console.WriteLine(sum);
            Console.Write("Произведение чисел: ");
            Console.WriteLine(product);
            Console.Write("Число десятков: ");
            Console.WriteLine(numberOfTens);
            Console.Write("Число едениц: ");
            Console.WriteLine(numberOfUnits);
            Console.ReadLine();
        }
        static void SixthTask()
        {
            Console.Write("Введите четырехзначное число: ");
            int fourDgitNumber = Convert.ToInt32(Console.ReadLine());
            int sumfourDgitNumber = (fourDgitNumber / 1000) + (fourDgitNumber % 100 / 10) + (fourDgitNumber % 10) + (fourDgitNumber / 100 % 10);
            int productfourDgitNumber = (fourDgitNumber / 1000) * (fourDgitNumber % 100 / 10) * (fourDgitNumber % 10) * (fourDgitNumber / 100 % 10);
            Console.Write("Сумма чисел: ");
            Console.WriteLine(sumfourDgitNumber);
            Console.Write("Произведение чисел: ");
            Console.WriteLine(productfourDgitNumber);
            Console.ReadLine();
        }
        static void SeventhTask()
        {
            int numberX;
            int nuberOne = 4;
            int nuberTwo = 5;
            int nuberThree = 6;
            numberX = nuberOne * 100 + nuberThree * 10 + nuberTwo;
            Console.WriteLine(numberX);
            Console.ReadLine();
        }
        static void EighthTask()
        {
            bool x = true;
            bool y = true;
            Console.WriteLine(!x && !y);
            Console.WriteLine(x || (!x && y));
            Console.WriteLine((!x && y) || y);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
            ThirdTask();
            FourthTask();
            FifthTask();
            SixthTask();
            SeventhTask();
            EighthTask();
        }
    }
}
