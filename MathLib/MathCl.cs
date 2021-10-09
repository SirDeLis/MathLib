using System;
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
            double finded = arr[0];//количество найдены чисел не может быть больше одного
            int findedIndex = 0;//количество найдены индексов не может быть больше одного
            for (int i = 0; i < arr.Length; i++)
            {
                if (dir)
                {
                    if (finded < arr[i])
                    {
                        finded = arr[i];//требуется повторная проверка на повторение максимального числа и сохранение его в массив
                        findedIndex = i;
                    }
                }
                else
                {
                    if (finded > arr[i])
                    {
                        finded = arr[i];//требуется повторная проверка на повторение минимального числа и сохранение его в массив
                        findedIndex = i;
                    }
                }
            }
            double[] result = { finded, findedIndex };//структура результата должна быть более сложной
            return result;
        }
        public static double ArrDet(double[,] arr)
        {
            double det;//отсутствует опеределение определителя матрицы состоящего из 1 элемента (det=arr[0,0]) 

            if (arr.GetLength(0) == 2 && arr.GetLength(1) == 2)//для определения является ли матрица квадратной необходимо использовать условие: arr.GetLength(0) == arr.GetLength(1), но это если необходимо найти определитель матрицы n строк на n столбцов
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
            }else if(arr.GetLength(0) == 4 && arr.GetLength(1) == 4) //отсутствует опеределение определителя матрицы состоящего из более 4x4 элементов 
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
            if (arr1.GetLength(0) == arr2.GetLength(0) && arr1.GetLength(1) == arr2.GetLength(1))//отсутствуют действия, при ложном условии сложения двух матриц, т.е. else { return null; }.
            {
                for (int i = 0; i < arr1.GetLength(0); i++)
                {
                    for (int y = 0; y < arr1.GetLength(1); y++)
                    {
                        arr1[i, y] += arr2[i, y];//необходимо создать итоговый массив, в который будут заносится все результаты, поскольку данная функция изменяет и возвращяет массив, который передал пользователь, т.е. после выполнения этой функции arr1 изменятся во всей программе, чего быть не должно, поскольку функция возврящает значение
                    }
                }
            }
            return (arr1);

        }
        public static double[,] MatrixMul(double[,] arr1, double[,] arr2)
        {
            double[,] arr = { { 0 },{ 0 } };//бесмысленная инициальзация переменной
            if (arr1.GetLength(0) == arr2.GetLength(1))//отсутствуют действия при ложном условии else {return null;}. при ложном условии функция вернёт вертикальную матрицу, у которой 2 элемента 0. + неверно указано условие (должно быть: if (arr1.GetLength(1) == arr2.GetLength(0)))
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
            return arr;//возвращять arr функция должна при истином условии, т.е. return должен быть внутри ветвления if
        }

    }

}
