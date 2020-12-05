using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //№1
            /*Console.WriteLine("Введите три числа: ");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"{firstNumber}  {secondNumber}  {thirdNumber}");

            //№2
            Console.WriteLine($"5\n10\n21");*/


            //№3
            /*Console.WriteLine("Введите расстояние в сантиметрах: ");
            int centimeters = int.Parse(Console.ReadLine());
            int meter = centimeters / 100;
            Console.WriteLine($"количество полных метров: {meter}");*/


            //№4
            /*int dayAmount = 234;
            double weeksAmount = dayAmount/7;
            Console.WriteLine($"Количество полных недель:  {weeksAmount}");*/


            //№5
            /*int Num1;
            Console.WriteLine("Введите двузначное число");
            Num1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Число десяток в нем = {0}", Num1 / 10); 
            Console.WriteLine("Число единиц в нем = {0}", Num1 % 10);
            Console.WriteLine("Сумма его цифр = {0}", Num1 % 10 + Num1 / 10);
            Console.WriteLine("Произведение его цифр = {0}", (Num1 % 10) * (Num1 / 10));*/


            //№6
            /*bool A = true;
            bool B = false;
            bool C = false;
            bool firstResult = A | B;
            bool secondResult = A & B;
            bool thirdResult = B | C;
            Console.WriteLine($"{firstResult}, {secondResult}, {thirdResult}");*/


            //№7
            /* Console.WriteLine("Введите радиус круга: ");
             double circleRadius = double.Parse(Console.ReadLine());
             Console.WriteLine("Введите сторону квадрата: ");
             double sideSquare = double.Parse(Console.ReadLine());
             double circleSquare = 3.14 * (circleRadius * circleRadius);
             double quadrateSquare = sideSquare * sideSquare;
             if (quadrateSquare > circleSquare)
             {
                 Console.WriteLine($"Площадь квадрата {quadrateSquare} > площади круга {circleSquare}");
             }
             else if (circleSquare > quadrateSquare) {
                 Console.WriteLine($"Площадь круга {circleSquare} > площади квадрата {quadrateSquare}"); 
             }
             else if(circleSquare == quadrateSquare)
             {
                 Console.WriteLine("Площади равны!");
             }*/



            //№8
            /*Console.WriteLine("Введите объем и массу первого тела");
            double firstBodyVolume = double.Parse(Console.ReadLine());
            double firstBodyMass = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите объем и массу второго тела");
            double secondBodyVolume = double.Parse(Console.ReadLine());
            double secondBodyMass = double.Parse(Console.ReadLine());
            double firstDensity = firstBodyMass / firstBodyVolume;
            double secondDensity = secondBodyMass / secondBodyVolume;
            if(firstDensity> secondDensity)
            {
                Console.WriteLine($"{firstDensity}>{secondDensity}: Плотность первого тела больше");
            }
            else if(secondDensity> firstDensity)
            {
                Console.WriteLine($"{secondDensity}>{firstDensity}: Плотность второго тела больше");
            }
            else if(secondDensity== firstDensity)
            {
                Console.WriteLine($"{firstDensity}={secondDensity}: Плотности тел равны");
            }*/


            //№9
            /*Console.WriteLine("Введите первые сопротивление и напряжение: ");
            double firstResistance = double.Parse(Console.ReadLine());
            double firstVoltage = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторые сопротивление и напряжение: ");
            double secondtResistance = double.Parse(Console.ReadLine());
            double secondVoltage = double.Parse(Console.ReadLine());
            double firstCurrent = firstVoltage / firstResistance;
            double secondCurrent = secondVoltage / secondtResistance;
            if(firstCurrent< secondCurrent)
            {
                Console.WriteLine($"{firstCurrent}: по первому участку протекает меньший ток.");
            }
            else if (firstCurrent > secondCurrent)
            {
                Console.WriteLine($"{secondCurrent}: по второму участку протекает меньший ток.");
            }
            else if (firstCurrent == secondCurrent)
            {
                Console.WriteLine("они равны");
            }*/


            //№10(a)
            /*
            for(int i = 20; i < 35; i++)
            {
                Console.WriteLine(i);
            }*/


            //№10(b)
            /*Console.WriteLine("Введите число больше 10");
            int someNumber = int.Parse(Console.ReadLine());
            for(int i = 10; i < someNumber; i++)
            {
                Console.WriteLine($"{i} в квадрате = {Math.Pow(i, 2)}");
            }*/


            //№10(c)
            /*Console.WriteLine("Введите число меньше 50");
            int anotherNumber = int.Parse(Console.ReadLine());
            for (int i = anotherNumber; i <50; i++)
            {
                Console.WriteLine($"{i} в третьей степени = {Math.Pow(i, 3)}");
            }*/


            //№10(d)
            /*Console.WriteLine("Введите начало промежутка:  ");
            int beginNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец промежутка:  ");
            int endNumber = int.Parse(Console.ReadLine());
            for (int i = beginNumber; i < endNumber;  i++)
            {
                Console.WriteLine(i); 
            }*/


        }
    }
}
