//Блок подключения других пространств имен
using System;

//Хз зачем, если оно неиспользованные директива не нужна, если хочешь удалить можно.
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//Какое-то пространство имен с названием MathLib
namespace MathLib
{ //Вложенное пространства имен
    //Некий класс
    public class MathCl
    {
        //Возвращает объект, через который будет осуществляться Sum
        //Инициализация
        public static double Sum(double[] x)
        {
            //Создание объекта
            double sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i]; //Решение
            }
            return sum;
        }// Вычисляет сумма
        // Инициализация 
        public static double Mul(double[] x)// Вычисляет умножение
        {
            double sum = 1;
            for (int i = 0; i < x.Length; i++)
            {
                sum *= x[i]; //Решение
            }
            return sum;
        }
        public static double Average(double[] x)// Вычисляет выводить среднее число
        {
            double sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i]; //Решение
            }
            sum /= x.Length;
            return sum;
        }
        public static double GeomAverage(double[] x)// Вычисляет выводить среднее геометрическое число
        {
            double sum = 1;
            for (int i = 0; i < x.Length; i++)
            {
                sum *= x[i]; //Решение
            }
            sum = Math.Pow(sum, 1.0 / x.Length);
            return sum;
        }

    }

    public class Arranges
    {
        public static double[] ArrSort(double[] arr, bool dir) // Sort это сортирует элементы одномерного массива
        {
            Array.Sort(arr); //Перебор всех элементов массива Array
            if (!dir) //Если текущий элемент массива
            {
                Array.Reverse(arr);
            }
            return arr;
        }
        public static double[] ArrFind(double[] arr, bool dir)// Find находит элемент, который удовлеворяет определенному условию
        {

            double finded = arr[0];
            int findedIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (dir)
                {
                    if (finded < arr[i])
                    {
                        finded = arr[i];
                        findedIndex = i;
                    }
                }
                else
                {
                    if (finded > arr[i])
                    {
                        finded = arr[i];
                        findedIndex = i;
                    }
                }
            }
            double[] result = { finded, findedIndex };
            return result;
        }
        public static double ArrDet(double[,] arr)// Вычисление определителя матрицы
        {
            double det;
            if (arr.GetLength(0) == 2 && arr.GetLength(1) == 2)
            {
                det = (arr[0, 0] * arr[1, 1]) - (arr[0, 1] * arr[1, 0]); // Массивы
                return det;
            }
            else if (arr.GetLength(0) == 3 && arr.GetLength(1) == 3) // Массивы
            {
                det = arr[0, 0] * arr[1, 1] * arr[2, 2];
                det += arr[0, 1] * arr[1, 2] * arr[2, 0];
                det += arr[0, 2] * arr[1, 0] * arr[2, 1];
                det -= arr[0, 2] * arr[1, 1] * arr[2, 0];
                det -= arr[0, 0] * arr[1, 2] * arr[2, 1];
                det -= arr[0, 1] * arr[1, 0] * arr[2, 2];
                return det;
            }
            else if (arr.GetLength(0) == 4 && arr.GetLength(1) == 4) // Массивы
            {
                det = arr[0, 0] * (arr[1, 1] * arr[2, 2] * arr[3, 3] + arr[1, 2] * arr[2, 3] * arr[3, 1] + arr[1, 3] * arr[2, 1] * arr[3, 2] - arr[1, 3] * arr[2, 2] * arr[3, 1] - arr[1, 1] * arr[2, 3] * arr[3, 2] - arr[1, 2] * arr[2, 1] * arr[3, 3]);
                det -= arr[1, 0] * (arr[0, 1] * arr[2, 2] * arr[3, 3] + arr[0, 2] * arr[2, 3] * arr[3, 1] + arr[0, 3] * arr[2, 1] * arr[3, 2] - arr[0, 3] * arr[2, 2] * arr[3, 1] - arr[0, 1] * arr[2, 3] * arr[3, 2] - arr[0, 2] * arr[2, 1] * arr[3, 3]);
                det += arr[2, 0] * (arr[0, 1] * arr[1, 2] * arr[3, 3] + arr[0, 2] * arr[1, 3] * arr[3, 1] + arr[0, 3] * arr[1, 1] * arr[3, 2] - arr[0, 3] * arr[1, 2] * arr[3, 1] - arr[0, 1] * arr[1, 3] * arr[3, 2] - arr[0, 2] * arr[1, 1] * arr[3, 3]);
                det -= arr[3, 0] * (arr[0, 1] * arr[1, 2] * arr[2, 3] + arr[0, 2] * arr[1, 3] * arr[2, 1] + arr[0, 3] * arr[1, 1] * arr[2, 2] - arr[0, 3] * arr[1, 2] * arr[2, 1] - arr[0, 1] * arr[1, 3] * arr[2, 2] - arr[0, 2] * arr[1, 1] * arr[2, 3]);
                return det;
            }
            else
            {
                return Convert.ToDouble(null);
            }
        }
        public static double[,] MatrixSum(double[,] arr1, double[,] arr2)// Матричные элементы сумма
        {
            if (arr1.GetLength(0) == arr2.GetLength(0) && arr1.GetLength(1) == arr2.GetLength(1)) //Если текущий элемент массив равен нулю и одну
            {
                for (int i = 0; i < arr1.GetLength(0); i++)
                {
                    for (int y = 0; y < arr1.GetLength(1); y++)
                    {
                        arr1[i, y] += arr2[i, y];
                    }
                }
            }
            return (arr1);
        }
        public static double[,] MatrixMul(double[,] arr1, double[,] arr2)// Матричные элементы умножение
        {
            double[,] arr = { { 0 }, { 0 } };
            if (arr1.GetLength(0) == arr2.GetLength(1))
            {
                arr = new double[arr1.GetLength(0), arr2.GetLength(1)];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int y = 0; y < arr.GetLength(1); y++)
                    {
                        arr[i, y] = 0;
                        for (int k = 0; k < arr1.GetLength(1); k++)
                        {

                            arr[i, y] += arr1[i, k] * arr2[k, y]; //Решение
                        }
                    }
                }
            }
            return arr;
        }

    }

}
