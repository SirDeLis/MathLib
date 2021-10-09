using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib;

namespace Tests
{
    class Program
    {

        //////////////////////////
        ///       MATH CL      ///
        //////////////////////////
        static void SumTest()
        {
            Random rdm = new Random();
            using (StreamWriter sw = new StreamWriter("SumTest.txt"))
            {
                for (int i = 0; i < 20; i++)
                {
                    sw.WriteLine("========Тест №{0}========", i + 1);
                    int razm = rdm.Next(1, 10);
                    sw.WriteLine("Размерность массива: {0}", razm);
                    double[] arr = new double[razm];
                    for (int j = 0; j < razm; j++)
                    {
                        arr[j] = rdm.NextDouble() * 1000;
                        sw.WriteLine("Число под номером {0} = {1}", j + 1, arr[j]);
                    }
                    double otvet = MathCl.Sum(arr);
                    sw.WriteLine("Сумма чисел равна " + otvet);
                }
            }
        }

        static void MulTest()
        {
            Random rdm = new Random();
            using (StreamWriter sw = new StreamWriter("MulTest.txt"))
            {
                for (int i = 0; i < 20; i++)
                {
                    sw.WriteLine("========Тест №{0}========", i + 1);
                    int razm = rdm.Next(1, 10);
                    sw.WriteLine("Размерность массива: {0}", razm);
                    double[] arr = new double[razm];
                    for (int j = 0; j < razm; j++)
                    {
                        arr[j] = rdm.NextDouble() * 1000;
                        sw.WriteLine("Число под номером {0} = {1}", j + 1, arr[j]);
                    }
                    double otvet = MathCl.Mul(arr);
                    sw.WriteLine("Произведение чисел равна " + otvet);
                }
            }
        }

        static void AverageTest()
        {
            Random rdm = new Random();
            using (StreamWriter sw = new StreamWriter("AverageTest.txt"))
            {
                for (int i = 0; i < 20; i++)
                {
                    sw.WriteLine("========Тест №{0}========", i + 1);
                    int razm = rdm.Next(1, 10);
                    sw.WriteLine("Размерность массива: {0}", razm);
                    double[] arr = new double[razm];
                    for (int j = 0; j < razm; j++)
                    {
                        arr[j] = rdm.NextDouble() * 1000;
                        sw.WriteLine("Число под номером {0} = {1}", j + 1, arr[j]);
                    }
                    double otvet = MathCl.Sum(arr);
                    sw.WriteLine("Среднее значение равно " + otvet);
                }
            }
        }

        static void GeomAverageTest()
        {
            Random rdm = new Random();
            using (StreamWriter sw = new StreamWriter("GeomAverage.txt"))
            {
                for (int i = 0; i < 20; i++)
                {
                    sw.WriteLine("========Тест №{0}========", i + 1);
                    int razm = rdm.Next(1, 10);
                    sw.WriteLine("Размерность массива: {0}", razm);
                    double[] arr = new double[razm];
                    for (int j = 0; j < razm; j++)
                    {
                        arr[j] = rdm.NextDouble() * 1000;
                        sw.WriteLine("Число под номером {0} = {1}", j + 1, arr[j]);
                    }
                    double otvet = MathCl.Sum(arr);
                    sw.WriteLine("Среднее геометрическое значение равно " + otvet);
                }
            }
        }

        //////////////////////////
        ///       ARRANGES     ///
        //////////////////////////

        static void ArrSortTest()
        {
            Random rdm = new Random();
            using (StreamWriter sw = new StreamWriter("ArrSort.txt"))
            {
                for (int i = 0; i < 20; i++)
                {
                    sw.WriteLine("========Тест №{0}========", i + 1);
                    int razm = rdm.Next(1, 10);
                    sw.WriteLine("Размерность массива: {0}", razm);
                    bool dir = rdm.Next(0, 1) == 1 ? true : false;
                    sw.WriteLine("Направление по сортировке: {0}", dir);
                    double[] arr = new double[razm];
                    for (int j = 0; j < razm; j++)
                    {
                        arr[j] = rdm.NextDouble() * 1000;
                        sw.WriteLine("Число под номером {0} = {1}", j + 1, arr[j]);
                    }
                    double[] otvet = Arranges.ArrSort(arr, dir);
                    for (int j = 0; j < razm; j++)
                    {
                        sw.WriteLine("Отсортированное число под номером {0} = {1}", j + 1, otvet[j]);
                    }
                }
            }
        }
        static void ArrFindTest()
        {
            Random rdm = new Random();
            using (StreamWriter sw = new StreamWriter("ArrFind.txt"))
            {
                for (int i = 0; i < 20; i++)
                {
                    sw.WriteLine("========Тест №{0}========", i + 1);
                    int razm = rdm.Next(1, 10);
                    sw.WriteLine("Размерность массива: {0}", razm);
                    bool dir = rdm.Next(0, 1) == 1 ? true : false;
                    sw.WriteLine("Направление по сортировке: {0}", dir);
                    double[] arr = new double[razm];
                    for (int j = 0; j < razm; j++)
                    {
                        arr[j] = rdm.NextDouble() * 1000;
                        sw.WriteLine("Число под номером {0} = {1}", j + 1, arr[j]);
                    }
                    double[] otvet = Arranges.ArrFind(arr, dir);
                    for (int j = 0; j < otvet.Length; j++)
                    {
                        sw.WriteLine("Результат под номером {0} = {1}", j + 1, otvet[j]);
                    }
                }
            }
        }

        static void ArrDetTest()
        {
            Random rdm = new Random();
            using (StreamWriter sw = new StreamWriter("ArrDet.txt"))
            {
                for (int i = 0; i < 20; i++)
                {
                    sw.WriteLine("========Тест №{0}========", i + 1);
                    int razm1 = rdm.Next(1, 6);
                    int razm2 = rdm.Next(1, 6);
                    sw.WriteLine("Высота матрицы: {0}", razm1);
                    sw.WriteLine("Ширина матрицы: {0}", razm2);
                    double[,] arr = new double[razm1, razm2];
                    for (int j = 0; j < razm1; j++)
                    {
                        for (int k = 0; k < razm2; k++)
                        {
                            arr[j, k] = rdm.NextDouble() * 1000;
                            sw.WriteLine("Число под номером {0} {1} = {2}", j + 1, k + 1, arr[j, k]);
                        }
                    }
                    double otvet = Arranges.ArrDet(arr);
                    sw.WriteLine("Результат: " + otvet);
                }
            }
        }
        static void MatrixSumTest()
        {
            Random rdm = new Random();
            using (StreamWriter sw = new StreamWriter("MatrixSum.txt"))
            {
                for (int i = 0; i < 20; i++)
                {
                    sw.WriteLine("========Тест №{0}========", i + 1);
                    int razm1 = rdm.Next(1, 6);
                    int razm2 = rdm.Next(1, 6);
                    sw.WriteLine("Высота матрицы: {0}", razm1);
                    sw.WriteLine("Ширина матрицы: {0}", razm2);
                    double[,] arr1 = new double[razm1, razm2];
                    double[,] arr2 = new double[razm1, razm2];
                    sw.WriteLine("# Матрица 1 #", i + 1);
                    for (int j = 0; j < razm1; j++)
                    {
                        for (int k = 0; k < razm2; k++)
                        {
                            arr1[j, k] = rdm.NextDouble() * 1000;
                            sw.WriteLine("Число под номером {0} {1} = {2}", j + 1, k + 1, arr1[j, k]);
                        }
                    }
                    sw.WriteLine("# Матрица 2 #", i + 1);
                    for (int j = 0; j < razm1; j++)
                    {
                        for (int k = 0; k < razm2; k++)
                        {
                            arr1[j, k] = rdm.NextDouble() * 1000;
                            sw.WriteLine("Число под номером {0} {1} = {2}", j + 1, k + 1, arr2[j, k]);
                        }
                    }
                    double[,] otvet = Arranges.MatrixSum(arr1, arr2);
                    for (int j = 0; j < razm1; j++)
                        for (int k = 0; k < razm2; k++)
                            sw.WriteLine("Результат под номером {0} {1} = {2}", j + 1, k + 1, otvet[j, k]);
                }
            }
        }

        static void MatrixMulTest()
        {
            Random rdm = new Random();
            using (StreamWriter sw = new StreamWriter("MatrixMul.txt"))
            {
                for (int i = 0; i < 20; i++)
                {
                    sw.WriteLine("========Тест №{0}========", i + 1);
                    int razm11 = rdm.Next(1, 6);
                    int razm12 = rdm.Next(1, 6);
                    int razm21 = rdm.Next(1, 6);
                    int razm22 = rdm.Next(1, 6);
                    sw.WriteLine("Высота первой матрицы: {0}", razm11);
                    sw.WriteLine("Ширина первой матрицы: {0}", razm12);
                    sw.WriteLine("Высота второй матрицы: {0}", razm21);
                    sw.WriteLine("Ширина второй матрицы: {0}", razm22);

                    if (razm11 == razm22)
                        sw.WriteLine("\n!!!ЕСТЬ СОВПАДЕНИЕ!!!\n");

                    double[,] arr1 = new double[razm11, razm12];
                    sw.WriteLine(arr1.GetLength(0) + " " + arr1.GetLength(1));
                    double[,] arr2 = new double[razm21, razm22];
                    sw.WriteLine(arr2.GetLength(0) + " " + arr2.GetLength(1));
                    sw.WriteLine("# Матрица 1 #");
                    for (int j = 0; j < razm11; j++)
                    {
                        for (int k = 0; k < razm12; k++)
                        {
                            arr1[j, k] = Math.Round(rdm.NextDouble() * 1000, 2);
                            sw.WriteLine("Число под номером {0} {1} = {2}", j + 1, k + 1, arr1[j, k]);
                        }
                    }
                    sw.WriteLine("# Матрица 2 #");
                    for (int j = 0; j < razm21; j++)
                    {
                        for (int k = 0; k < razm22; k++)
                        {
                            arr2[j, k] = Math.Round(rdm.NextDouble() * 1000, 2);
                            sw.WriteLine("Число под номером {0} {1} = {2}", j + 1, k + 1, arr2[j, k]);
                        }
                    }
                    double[,] otvet = Arranges.MatrixMul(arr1, arr2);
                    sw.WriteLine("\n# Результат #");
                    for (int j = 0; j < otvet.GetLength(0); j++)
                        for (int k = 0; k < otvet.GetLength(1); k++)
                            sw.WriteLine("Результат под номером {0} {1} = {2}", j + 1, k + 1, otvet[j, k]);
                }
            }
        }


        static void Main(string[] args)
        {
            SumTest();
            MulTest();
            AverageTest();
            GeomAverageTest();
            ArrSortTest();
            ArrFindTest();
            ArrDetTest();
            MatrixSumTest();
            try 
            {
                MatrixMulTest();
            }
            catch
            {
                Console.WriteLine("Прога вылетает, если ширина второй матрицы больше чем высота первой, я не знаю почему :(\nНажмите ентер...");
                Console.ReadKey();
            }
        }
    }
}
