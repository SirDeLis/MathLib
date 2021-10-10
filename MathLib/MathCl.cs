using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks; библиотнки не используются

namespace MathLib
{
    public class MathCl//работает нормально
    {
        public static double Sum(double[] x)
        {
            double sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            return sum;
        }
        public static double Mul(double[] x)
        {
            double sum = 1;
            for (int i = 0; i < x.Length; i++)
            {
                sum *= x[i];
            }
            return sum;
        }
        public static double Average(double[] x)
        {
            double sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            sum /= x.Length;
            return sum;
        }
        public static double GeomAverage(double[] x)
        {
            double sum = 1;
            for (int i = 0; i < x.Length; i++)
            {
                sum *= x[i];
            }
            sum = Math.Pow(sum, 1.0 / x.Length);
            return sum;
        }

    }

    public class Arranges
    {
        public static double[] ArrSort(double[] arr, bool dir) //работает нормально
        {
            Array.Sort(arr);
            if (!dir)
            {
                Array.Reverse(arr);
            }
            return arr;
        }
        public static double[] ArrFind(double[] arr, bool dir)
        {
            double finded = arr[0]; //кол-во найденых чисел может быть > 1
            int findedIndex = 0; //кол-во найденых индексов может быть > 1
            for (int i = 0; i < arr.Length; i++)
            {
                if (dir)
                {
                    if (finded < arr[i])
                    {
                        finded = arr[i];//требувется проверка на повторение максимального числа и запись его индекса в массив
                        findedIndex = i;
                    }
                }
                else
                {
                    if (finded > arr[i])
                    {
                        finded = arr[i];//аналогично с поиском максимального
                        findedIndex = i;
                    }
                }
            }
            double[] result = { finded, findedIndex };//структура результата должна быть более сложной
            return result;
        }
        public static double ArrDet(double[,] arr) //работает нормально
        {
            double det;
            if (arr.GetLength(0) == 2 && arr.GetLength(1) == 2)
            {
                det = (arr[0, 0] * arr[1, 1]) - (arr[0, 1] * arr[1, 0]);
                return det;
            }else if (arr.GetLength(0) == 3 && arr.GetLength(1) == 3)
            {
                det = arr[0, 0] * arr[1, 1] * arr[2, 2];
                det += arr[0, 1] * arr[1, 2] * arr[2, 0];
                det += arr[0, 2] * arr[1, 0] * arr[2, 1];
                det -= arr[0, 2] * arr[1, 1] * arr[2, 0];
                det -= arr[0, 0] * arr[1, 2] * arr[2, 1];
                det-= arr[0, 1] * arr[1, 0] * arr[2, 2];
                return det;
            }else if(arr.GetLength(0) == 4 && arr.GetLength(1) == 4)
            {
                det = arr[0, 0] *(arr[1, 1] * arr[2, 2] * arr[3, 3]+ arr[1, 2] * arr[2, 3] * arr[3, 1]+ arr[1, 3] * arr[2, 1] * arr[3, 2]- arr[1, 3] * arr[2, 2] * arr[3, 1]- arr[1, 1] * arr[2, 3] * arr[3, 2]- arr[1, 2] * arr[2, 1] * arr[3, 3]);
                det -= arr[1, 0] * (arr[0, 1] * arr[2, 2] * arr[3, 3] + arr[0, 2] * arr[2, 3] * arr[3, 1] + arr[0, 3] * arr[2, 1] * arr[3, 2] - arr[0, 3] * arr[2, 2] * arr[3, 1] - arr[0, 1] * arr[2, 3] * arr[3, 2] - arr[0, 2] * arr[2, 1] * arr[3, 3]);
                det += arr[2, 0] *(arr[0, 1] * arr[1, 2] * arr[3, 3]+ arr[0, 2] * arr[1, 3] * arr[3, 1]+ arr[0, 3] * arr[1, 1] * arr[3, 2]- arr[0, 3] * arr[1, 2] * arr[3, 1]- arr[0, 1] * arr[1, 3] * arr[3, 2]- arr[0, 2] * arr[1, 1] * arr[3, 3]);
                det -= arr[3, 0] * (arr[0, 1] * arr[1, 2] * arr[2, 3] + arr[0, 2] * arr[1, 3] * arr[2, 1] + arr[0, 3] * arr[1, 1] * arr[2, 2] - arr[0, 3] * arr[1, 2] * arr[2, 1] - arr[0, 1] * arr[1, 3] * arr[2, 2] - arr[0, 2] * arr[1, 1] * arr[2, 3]);
                return det;
            }
            else
            {
                return Convert.ToDouble(null);
            }
        }
        public static double[,] MatrixSum(double[,] arr1, double[,] arr2)
        {
            if (arr1.GetLength(0) == arr2.GetLength(0) && arr1.GetLength(1) == arr2.GetLength(1)) //отсутствует оператор else, в случае если матрицы имеют разное кол-во столбцов и строк выводит первую матрицу
            {
                for(int i = 0; i < arr1.GetLength(0); i++)
                {
                    for(int y = 0; y < arr1.GetLength(1); y++)
                    {
                        arr1[i, y] += arr2[i, y]; //изменяется и возвращается одна из первоначальных матриц
                    }
                }
            }
            return (arr1);
        }
        public static double[,] MatrixMul(double[,] arr1, double[,] arr2)
        {
            //отсутсвует оповещение об ошибке в том случае, когда матрицы нельзя умножить друг на друга
            double[,] arr = { { 0 },{ 0 } };//матрица создана неверно
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
                            arr[i, y] += arr1[i, k] * arr2[k, y];
                        }
                    }
                }
            }
            return arr;
        }

    }

}
