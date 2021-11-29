using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib;

namespace ProjectProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] massiveOne = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9.5 };
            double[] massiveTwo = new double[] { };
            double[] massiveThree = new double[] { 1 };
            double[] massiveFour = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, -9.5 };
            double[] massiveFive = new double[] { -1 };
            double[] massiveSix = new double[] { 0 };


            double[,] massiveDoubleOne = new double[,] { { -1, 2, 3 }, { 4, -5, 6 }, { 7, -8, 9 } };
            double[,] massiveDoubleTwo = new double[,] { { 1, 2, 3, 1, 2 }, { 4, 5, 6, 1, 2 }, { 7, 8, 9, 1, 2 }, { 1, 2, 3, 1, 2 }, { 1, 2, 3, 1, 2 } };
            double[,] massiveDoubleThree = new double[,] { { 1} };
            double[,] massiveDoubleFour = new double[,] { { } };
            double[,] massiveDoubleFive = new double[,] { { 1, 2}, { 4, 5 }};
            double[,] massiveDoubleSix = new double[,] { { 1, 2, 3 }, { 4, 5, 6 } };


            //Тестирование MathCl

            Console.WriteLine("Сумма элементов массива: " + MathCl.Sum(massiveOne));//Сумма элементов массива должна быть равна 45.5
            Console.WriteLine("Сумма элементов массива: " + MathCl.Sum(massiveTwo));//Должно вывестись ничего
            Console.WriteLine("Сумма элементов массива: " + MathCl.Sum(massiveThree));//Сумма элементов массива должна быть равна 1
            Console.WriteLine("Сумма элементов массива: " + MathCl.Sum(massiveFour));//Сумма элементов массива должна быть равна 26.5
            Console.WriteLine("Сумма элементов массива: " + MathCl.Sum(massiveFive));//Сумма элементов массива должна быть равна -1
            Console.WriteLine("Сумма элементов массива: " + MathCl.Sum(massiveSix));//Сумма элементов массива должна быть равна 1

            Console.WriteLine();

            Console.WriteLine("Произведение элементов массива: " + MathCl.Mul(massiveOne));//Произведение элементов массива должна быть равна 383040
            Console.WriteLine("Произведение элементов массива: " + MathCl.Mul(massiveTwo));//Должно вывестись ничего
            Console.WriteLine("Произведение элементов массива: " + MathCl.Mul(massiveThree));//Произведение элементов массива должна быть равна 1
            Console.WriteLine("Произведение элементов массива: " + MathCl.Mul(massiveFour));//Произведение элементов массива должна быть равна -383040
            Console.WriteLine("Произведение элементов массива: " + MathCl.Mul(massiveFive));//Произведение элементов массива должна быть равна -1
            Console.WriteLine("Произведение элементов массива: " + MathCl.Mul(massiveSix));//Произведение элементов массива должна быть равна 0

            Console.WriteLine();


            Console.WriteLine("Среднее арифметическое элементов массива: " + MathCl.Average(massiveOne));//Среднее арифметическое элементов массива должна быть равна  5,0(5)
            Console.WriteLine("Среднее арифметическое элементов массива: " + MathCl.Average(massiveTwo));//Должно вывестись ничего
            Console.WriteLine("Среднее арифметическое элементов массива: " + MathCl.Average(massiveThree));//Среднее арифметическое элементов массива должна быть равна 1
            Console.WriteLine("Среднее арифметическое элементов массива: " + MathCl.Average(massiveFour));//Среднее арифметическое элементов массива должна быть равна 2,9(4)
            Console.WriteLine("Среднее арифметическое элементов массива: " + MathCl.Average(massiveFive));//Среднее арифметическое элементов массива должна быть равна -1
            Console.WriteLine("Среднее арифметическое элементов массива: " + MathCl.Average(massiveSix));//Среднее арифметическое элементов массива должна быть равна 0

            Console.WriteLine();

            Console.WriteLine("Среднее геометрическое элементов массива: " + MathCl.GeomAverage(massiveOne));//Среднее геометрическое элементов массива должна быть равна  ~ 4,172
            Console.WriteLine("Среднее геометрическое элементов массива: " + MathCl.GeomAverage(massiveTwo));//Должно вывестись ничего
            Console.WriteLine("Среднее геометрическое элементов массива: " + MathCl.GeomAverage(massiveThree));//Среднее геометрическое элементов массива должна быть равна 1
            Console.WriteLine("Среднее геометрическое элементов массива: " + MathCl.GeomAverage(massiveFour));//Должно вывестись ничего
            Console.WriteLine("Среднее геометрическое элементов массива: " + MathCl.GeomAverage(massiveFive));//Среднее геометрическое элементов массива должна быть равна -1
            Console.WriteLine("Среднее геометрическое элементов массива: " + MathCl.GeomAverage(massiveSix));//Среднее геометрическое элементов массива должна быть равна 0

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //Теcтирование класса Arranges
                //начало тестирование поиска максимального числа матрицы
            Console.WriteLine("\n\n\nМаксимальное число; индекс максимального числа");
            var temp = Arranges.ArrFind(massiveOne, true);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }

            Console.WriteLine("\nМаксимальное число; индекс максимального числа //Необработанное исключение");
            //temp = Arranges.ArrFind(massiveTwo, true);
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    Console.Write(temp[i] + "; ");
            //}
            Console.WriteLine("\nМаксимальное число; индекс максимального числа");
            temp = Arranges.ArrFind(massiveThree, true);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }
            Console.WriteLine("\nМаксимальное число; индекс максимального числа");
            temp = Arranges.ArrFind(massiveFour, true);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }
            Console.WriteLine("\nМаксимальное число; индекс максимального числа");
            temp = Arranges.ArrFind(massiveFive, true);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }
            Console.WriteLine("\nМаксимальное число; индекс максимального числа");
            temp = Arranges.ArrFind(massiveSix, true);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }

            Console.WriteLine("\n\n\nМинимальное число; индекс максимального числа");
            temp = Arranges.ArrFind(massiveOne, false);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }

            Console.WriteLine("\nМинимальное число; индекс максимального числа //Необработанное исключение");
            //temp = Arranges.ArrFind(massiveTwo, false);
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    Console.Write(temp[i] + "; ");
            //}
            Console.WriteLine("\nМинимальное число; индекс максимального числа");
            temp = Arranges.ArrFind(massiveThree, false);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }
            Console.WriteLine("\nМинимальное число; индекс максимального числа");
            temp = Arranges.ArrFind(massiveFour, false);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }
            Console.WriteLine("\nМинимальное число; индекс максимального числа");
            temp = Arranges.ArrFind(massiveFive, false);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }
            Console.WriteLine("\nМинимальное число; индекс максимального числа");
            temp = Arranges.ArrFind(massiveSix, false);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }




                //начало тестирования нахождения определителя матрицы 
            Console.WriteLine("\nОпределитель матрицы равен: " +Arranges.ArrDet(massiveDoubleOne));//det=18
            Console.WriteLine("Определитель матрицы равен: " +Arranges.ArrDet(massiveDoubleTwo));//Должен вывести число
            Console.WriteLine("Определитель матрицы равен: " +Arranges.ArrDet(massiveDoubleThree));//Должен вывести число
            Console.WriteLine("Определитель матрицы равен: " +Arranges.ArrDet(massiveDoubleFour));//Должно вывестись ничего
            Console.WriteLine("Определитель матрицы равен: " +Arranges.ArrDet(massiveDoubleFive));//det=-3
            Console.WriteLine("Определитель матрицы равен: " +Arranges.ArrDet(massiveDoubleSix));//Должно вывестись ничего






            //начало тестирование сортировки по возростанию
            Console.WriteLine("\n\n\nСортировка по возростанию массива:");
            temp = Arranges.ArrSort(massiveOne,true);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }

            Console.WriteLine("\nСортировка по возростанию массива:");
            temp = Arranges.ArrSort(massiveTwo, true);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }
            Console.WriteLine("\nСортировка по возростанию массива:");
            temp = Arranges.ArrSort(massiveThree, true);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }
            Console.WriteLine("\nСортировка по возростанию массива:");
            temp = Arranges.ArrSort(massiveFour, true);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }
            Console.WriteLine("\nСортировка по возростанию массива:");
            temp = Arranges.ArrSort(massiveFive, true);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }
            Console.WriteLine("\nСортировка по возростанию массива:");
            temp = Arranges.ArrSort(massiveSix, true);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }

                //начало тестирование сортировки по убыванию
            Console.WriteLine("\n\n\nСортировка по убыванию массива:");
            temp = Arranges.ArrSort(massiveOne, false);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }

            Console.WriteLine("\nСортировка по убыванию массива:");
            temp = Arranges.ArrSort(massiveTwo, false);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }
            Console.WriteLine("\nСортировка по убыванию массива:");
            temp = Arranges.ArrSort(massiveThree, false);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }
            Console.WriteLine("\nСортировка по убыванию массива:");
            temp = Arranges.ArrSort(massiveFour, false);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }
            Console.WriteLine("\nСортировка по убыванию массива:");
            temp = Arranges.ArrSort(massiveFive, false);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }
            Console.WriteLine("\nСортировка по убыванию массива:");
            temp = Arranges.ArrSort(massiveSix, false);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + "; ");
            }











            //for (int i = 0; i < massiveDoubleOne.GetLength(0); i++)
            //{
            //    for (int k = 0; k < massiveDoubleOne.GetLength(1); k++)
            //    {
            //        Console.Write(massiveDoubleOne[i, k] + "; ");
            //    }
            //    Console.WriteLine();
            //}


            Console.ReadLine();
        }
    }
}
