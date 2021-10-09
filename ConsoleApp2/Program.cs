using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tests t = new Tests();
            //Тесты для класса Arranges
            t.ArrSortTest();
            t.ArrDetTest();
            t.ArrFindTest();
            t.MatrixSumTest();
            t.MatrixMulTest();
            //Тесты для класса MathCl
            t.SumTest();
            t.MulTest();
            t.AverageTest();
            t.GeomAverageTest();
        }

    }
    class Tests
    {
        double result;
        double[] arr;
        double[,] math;
        double[,] math1;
        double[,] math2;
        Random r = new Random();
        //метод записи массива в файл
        void WriteArr(double[] arr, string filename, string message)
        {
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.WriteLine(message);
                foreach (var a in arr)
                {
                    sw.Write(a + "\t");
                }
                sw.WriteLine();
            }
        }
        //метод записи матрицы в файл
        void WriteMath(double[,] math, string filename, string message)
        {
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.WriteLine(message);
                for (int i = 0; i < math.GetLength(0); i++)
                {
                    for (int j = 0; j < math.GetLength(1); j++)
                        sw.Write(math[i, j] + "\t");
                    sw.WriteLine();
                }
            }
        }
        //создает массив рандомной длины от 0 до 10 с рандомными значениями от -1000 до 1000
        double[] MakeRandomArr(double[] ar)
        {
            Random rand = new Random();
            int n = rand.Next(0, 10);
            ar = new double[n];
            for (int i = 0; i < n; i++)
                ar[i] = rand.Next(-1000, 1000);
            return ar;
        }
        //создает матрицу рандомной размерности от 0,0 до 6,6 с рандомными значениями от -1000 до 1000
        double[,] MakeRandomMath(double[,] mat)
        {
            Random rand = new Random();
            int n = rand.Next(0, 6);
            System.Threading.Thread.Sleep(100);
            int m = rand.Next(0, 6);
            mat = new double[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    mat[i, j] = rand.Next(-1000, 1000);
            return mat;
        }
        public void SumTest()
        {
            string filename = "SumTest.txt";
            try
            {
                for (int k = 0; k < 20; k++)
                {
                    arr = MakeRandomArr(arr);
                    WriteArr(arr, filename, "Исходные данные");
                    result = MathCl.Sum(arr);
                    using (StreamWriter sw = new StreamWriter(filename, true))
                        sw.WriteLine("Итоговые данные\n{0}", result);
                    System.Threading.Thread.Sleep(100);
                }
            }
            catch (Exception e)
            {
                using (StreamWriter sw = new StreamWriter(filename, true))
                    sw.WriteLine("Ошибка: " + e.Message + "\nИсточник: " + e.TargetSite);
            }
        }
        public void MulTest()
        {
            string filename = "MulTest.txt";
            try
            {
                for (int k = 0; k < 20; k++)
                {
                    arr = MakeRandomArr(arr);
                    WriteArr(arr, filename, "Исходные данные");
                    result = MathCl.Mul(arr);
                    using (StreamWriter sw = new StreamWriter(filename, true))
                        sw.WriteLine("Итоговые данные\n{0}", result);
                    System.Threading.Thread.Sleep(100);
                }
            }
            catch (Exception e)
            {
                using (StreamWriter sw = new StreamWriter(filename, true))
                    sw.WriteLine("Ошибка: " + e.Message + "\nИсточник: " + e.TargetSite);
            }
        }
        public void AverageTest()
        {
            string filename = "AverageTest.txt";
            try
            {
                for (int k = 0; k < 20; k++)
                {
                    arr = MakeRandomArr(arr);
                    WriteArr(arr, filename, "Исходные данные");
                    result = MathCl.Average(arr);
                    using (StreamWriter sw = new StreamWriter(filename, true))
                        sw.WriteLine("Итоговые данные\n{0}", result);
                    System.Threading.Thread.Sleep(100);
                }
            }
            catch (Exception e)
            {
                using (StreamWriter sw = new StreamWriter(filename, true))
                    sw.WriteLine("Ошибка: " + e.Message + "\nИсточник: " + e.TargetSite);
            }
        }
        public void GeomAverageTest()
        {
            string filename = "GeomAverageTest.txt";
            try
            {
                for (int k = 0; k < 20; k++)
                {
                    arr = MakeRandomArr(arr);
                    WriteArr(arr, filename, "Исходные данные");
                    result = MathCl.GeomAverage(arr);
                    using (StreamWriter sw = new StreamWriter(filename, true))
                        sw.WriteLine("Итоговые данные\n{0}", result);
                    System.Threading.Thread.Sleep(100);
                }
            }
            catch (Exception e)
            {
                using (StreamWriter sw = new StreamWriter(filename, true))
                    sw.WriteLine("Ошибка: " + e.Message + "\nИсточник: " + e.TargetSite);
            }
        }
        public void ArrSortTest()
        {
            string filename = "ArrSortTest.txt";
            try
            {
                for (int k = 0; k < 20; k++)
                {
                    arr = MakeRandomArr(arr);
                    WriteArr(arr, filename, "Исходные данные");
                    arr = Arranges.ArrSort(arr, Convert.ToBoolean(r.Next(0, 1)));
                    WriteArr(arr, filename, "Итоговые данные");
                    System.Threading.Thread.Sleep(100);
                }
            }
            catch (Exception e)
            {
                using (StreamWriter sw = new StreamWriter(filename, true))
                    sw.WriteLine("Ошибка: " + e.Message + "\nИсточник: " + e.TargetSite);
            }
        }
        public void ArrFindTest()
        {
            string filename = "ArrFindTest.txt";
            try
            {
                for (int k = 0; k < 20; k++)
                {
                    arr = MakeRandomArr(arr);
                    WriteArr(arr, filename, "Исходные данные");
                    arr = Arranges.ArrFind(arr, Convert.ToBoolean(r.Next(0, 1)));
                    WriteArr(arr, filename, "Итоговые данные");
                    System.Threading.Thread.Sleep(100);
                }
            }
            catch (Exception e)
            {
                using (StreamWriter sw = new StreamWriter(filename, true))
                    sw.WriteLine("Ошибка: " + e.Message + "\nИсточник: " + e.TargetSite);
            }
        }
        public void ArrDetTest()
        {
            string filename = "ArrDetTest.txt";
            try
            {
                for (int k = 0; k < 20; k++)
                {
                    math = MakeRandomMath(math);
                    WriteMath(math, filename, "Исходные данные");
                    result = Arranges.ArrDet(math);
                    using (StreamWriter sw = new StreamWriter(filename, true))
                        sw.WriteLine("Итоговые данные\n{0}", result);
                    System.Threading.Thread.Sleep(100);                    
                }
            }
            catch (Exception e)
            {
                using (StreamWriter sw = new StreamWriter(filename, true))
                    sw.WriteLine("Ошибка: " + e.Message + "\nИсточник: " + e.TargetSite);
            }
        }
        public void MatrixSumTest()
        {
            string filename = "MatrixSumTest.txt";
            try
            {
                for (int k = 0; k < 20; k++)
                {
                    math1 = MakeRandomMath(math1);
                    WriteMath(math1, filename, "Исходные данные матрицы 1");
                    math2 = MakeRandomMath(math2);
                    WriteMath(math2, filename, "Исходные данные матрицы 2");
                    math = Arranges.MatrixSum(math1, math2);
                    WriteMath(math, filename, "Итоговый результат");
                    System.Threading.Thread.Sleep(100);
                }
            }
            catch (Exception e)
            {
                using (StreamWriter sw = new StreamWriter(filename, true))
                    sw.WriteLine("Ошибка: " + e.Message + "\nИсточник: " + e.TargetSite);
            }
        }
        public void MatrixMulTest()
        {
            string filename = "MatrixMulTest.txt";
            try
            {
                for (int k = 0; k < 20; k++)
                {
                    math1 = MakeRandomMath(math1);
                    WriteMath(math1, filename, "Исходные данные матрицы 1");
                    math2 = MakeRandomMath(math2);
                    WriteMath(math2, filename, "Исходные данные матрицы 2");
                    math = Arranges.MatrixSum(math1, math2);
                    WriteMath(math, filename, "Итоговый результат");
                    System.Threading.Thread.Sleep(100);
                }
            }
            catch (Exception e)
            {
                using (StreamWriter sw = new StreamWriter(filename, true))
                    sw.WriteLine("Ошибка: " + e.Message + "\nИсточник: " + e.TargetSite);
            }
        }
    }
}
