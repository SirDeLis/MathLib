﻿using System;
// не использованные библиотеки
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class MathCl
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
            // ввести переменную, чтобы в случае, если массив пуст то возвращал 0
            double sum = 1;// переименовать в mul
            // bool hasElement = false
            for (int i = 0; i < x.Length; i++)
            {
                sum *= x[i];
                //hasElement  = true;
            }
            //if(hasElement)
            //{
            // return sum;
            //}
            //else
            //{
            //  return 0;
            //}
            return sum;
        }
        public static double Average(double[] x)
        {
            // добавить проверку, что длина массива > 0
            double sum = 0; // переименовать в аve
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            sum /= x.Length;
            return sum;
        }
        public static double GeomAverage(double[] x)
        {
            // добавить проверку, что длина массива > 0
            double sum = 1; // переименовать в geomAve
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
        public static double[] ArrSort(double[] arr, bool dir)
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
            // добавить проверку, что длина массива > 0
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
        public static double ArrDet(double[,] arr)
        {
            // чтобы убрать дублирование кода return можно делать один раз в конце
            double det;
            if (arr.GetLength(0) == 2 && arr.GetLength(1) == 2)
            {
                det = (arr[0, 0] * arr[1, 1]) - (arr[0, 1] * arr[1, 0]);
                //return det; 
            }
            else if (arr.GetLength(0) == 3 && arr.GetLength(1) == 3)
            {
                det = arr[0, 0] * arr[1, 1] * arr[2, 2];
                det += arr[0, 1] * arr[1, 2] * arr[2, 0];
                det += arr[0, 2] * arr[1, 0] * arr[2, 1];
                det -= arr[0, 2] * arr[1, 1] * arr[2, 0];
                det -= arr[0, 0] * arr[1, 2] * arr[2, 1];
                det -= arr[0, 1] * arr[1, 0] * arr[2, 2];
                //return det;
            }
            else if (arr.GetLength(0) == 4 && arr.GetLength(1) == 4)
            {
                det = arr[0, 0] * (arr[1, 1] * arr[2, 2] * arr[3, 3] + arr[1, 2] * arr[2, 3] * arr[3, 1] + arr[1, 3] * arr[2, 1] * arr[3, 2] - arr[1, 3] * arr[2, 2] * arr[3, 1] - arr[1, 1] * arr[2, 3] * arr[3, 2] - arr[1, 2] * arr[2, 1] * arr[3, 3]);
                det -= arr[1, 0] * (arr[0, 1] * arr[2, 2] * arr[3, 3] + arr[0, 2] * arr[2, 3] * arr[3, 1] + arr[0, 3] * arr[2, 1] * arr[3, 2] - arr[0, 3] * arr[2, 2] * arr[3, 1] - arr[0, 1] * arr[2, 3] * arr[3, 2] - arr[0, 2] * arr[2, 1] * arr[3, 3]);
                det += arr[2, 0] * (arr[0, 1] * arr[1, 2] * arr[3, 3] + arr[0, 2] * arr[1, 3] * arr[3, 1] + arr[0, 3] * arr[1, 1] * arr[3, 2] - arr[0, 3] * arr[1, 2] * arr[3, 1] - arr[0, 1] * arr[1, 3] * arr[3, 2] - arr[0, 2] * arr[1, 1] * arr[3, 3]);
                det -= arr[3, 0] * (arr[0, 1] * arr[1, 2] * arr[2, 3] + arr[0, 2] * arr[1, 3] * arr[2, 1] + arr[0, 3] * arr[1, 1] * arr[2, 2] - arr[0, 3] * arr[1, 2] * arr[2, 1] - arr[0, 1] * arr[1, 3] * arr[2, 2] - arr[0, 2] * arr[1, 1] * arr[2, 3]);
                //return det;
            }
            else
            {
                return Convert.ToDouble(null);
            }
            return det;
        }
        public static double[,] MatrixSum(double[,] arr1, double[,] arr2)
        {
            //добавить новую переменную result[,], чтобы в случае не выполнения
            //условия метод не возращал arr1 как сумму матриц
            if (arr1.GetLength(0) == arr2.GetLength(0) && arr1.GetLength(1) == arr2.GetLength(1))  // отсутствует else
            {
                for (int i = 0; i < arr1.GetLength(0); i++)
                {
                    for (int y = 0; y < arr1.GetLength(1); y++)
                    {
                        arr1[i, y] += arr2[i, y]; // записывать в переменную result
                    }
                }
            }
            return (arr1); // вернуть result
        }
        public static double[,] MatrixMul(double[,] arr1, double[,] arr2)
        {
            double[,] arr = { { 0 }, { 0 } };// альтернативный синтаксис для new double[0, 0];
            if (arr1.GetLength(0) == arr2.GetLength(1)) // отсутствует else
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
