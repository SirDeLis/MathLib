using System;

namespace ConsoleApp2
{
    class Program
    {
        static void enter_lesson_1()
        {
            // Рандом
            Random rand = new Random();
            // Максимальное значение
            byte[] kol = new byte[classPath.maxValue];
            // Кол-во тестов
            double[,] nums1 = new double[21, 21];

            // Генерация случайных чисел (6 раз)
            for (byte i = 0; i < classPath.maxValue; i++)
            {
                kol[i] = (byte)rand.Next(2, 6);
            }

            // Для метода сложения
            for (byte kolTest = 0; kolTest < classPath.maxValue; kolTest++)
            {
                for (byte i = 0; i < kol.Length; i++)
                {
                    nums1[i, kolTest] = rand.Next(1, 7);
                }
            }
            classMethods.lessons_1(nums1, kol, 1);

            // Для метода умножения
            for (byte kolTest = 0; kolTest < classPath.maxValue; kolTest++)
            {
                for (byte i = 0; i < kol.Length; i++)
                {
                    nums1[i, kolTest] = rand.Next(1, 7);
                }
            }
            classMethods.lessons_1(nums1, kol, 2);

            // Для метода Average
            for (byte kolTest = 0; kolTest < classPath.maxValue; kolTest++)
            {
                for (byte i = 0; i < kol.Length; i++)
                {
                    nums1[i, kolTest] = rand.Next(1, 7);
                }
            }
            classMethods.lessons_1(nums1, kol, 3);

            // Для метода GeomAverage
            for (byte kolTest = 0; kolTest < classPath.maxValue; kolTest++)
            {
                for (byte i = 0; i < kol.Length; i++)
                {
                    nums1[i, kolTest] = rand.Next(1, 7);
                }
            }
            classMethods.lessons_1(nums1, kol, 4);
        }

        static void enter_lesson_2()
        {
            Random rand = new Random();

            bool dir = rand.Next(0, 2) > 0;
            byte[] kolStroka = new byte[classPath.maxValue];
            byte[] kolStolbik = new byte[classPath.maxValue];
            double[,] nums = new double[classPath.maxValue, classPath.maxValue];

            for (byte i = 0; i < classPath.maxValue; i++)
            {
                kolStroka[i] = (byte)rand.Next(2, 7);
                kolStolbik[i] = (byte)rand.Next(2, 7);
            }

            for (byte kolTest = 0; kolTest < classPath.maxValue; kolTest++)
            {
                for (byte i = 0; i < kolStroka.Length; i++)
                {
                    nums[i, kolTest] = rand.Next(2, 9);
                }
            }
            classMethods.arrSort_arrFind(nums, kolStroka, dir, 1);

            for (byte kolTest = 0; kolTest < classPath.maxValue; kolTest++)
            {
                for (byte i = 0; i < kolStroka.Length; i++)
                {
                    nums[i, kolTest] = rand.Next(2, 9);
                }
            }
            classMethods.arrSort_arrFind(nums, kolStroka, dir, 2);

            double[,,] numsMatrix = new double[classPath.maxValue, classPath.maxValue, classPath.maxValue];

            for (byte kolTest = 0; kolTest < classPath.maxValue; kolTest++)
            {
                for (byte i = 0; i < kolStolbik.Length; i++)
                {
                    for (byte j = 0; j < kolStroka.Length; j++)
                    {
                        numsMatrix[j, i, kolTest] = rand.Next(2, 9);
                    }
                }
            }
            classMethods.arrDet(numsMatrix, kolStolbik, kolStroka);

            double[,,] numsMatrix_1 = new double[classPath.maxValue, classPath.maxValue, classPath.maxValue];
            double[,,] numsMatrix_2 = new double[classPath.maxValue, classPath.maxValue, classPath.maxValue];

            for (byte kolTest = 0; kolTest < classPath.maxValue; kolTest++)
            {
                for (byte i = 0; i < kolStolbik.Length; i++)
                {
                    for (byte j = 0; j < kolStroka.Length; j++)
                    {
                        numsMatrix_1[j, i, kolTest] = rand.Next(2, 9);
                    }
                }
                for (byte i = 0; i < kolStolbik.Length; i++)
                {
                    for (byte j = 0; j < kolStroka.Length; j++)
                    {
                        numsMatrix_2[j, i, kolTest] = rand.Next(2, 9);
                    }
                }
            }
            classMethods.matrixSum_matrixMul(numsMatrix_1, numsMatrix_2, kolStolbik, kolStroka, 1);

            for (byte kolTest = 0; kolTest < classPath.maxValue; kolTest++)
            {
                for (byte i = 0; i < kolStolbik.Length; i++)
                {
                    for (byte j = 0; j < kolStroka.Length; j++)
                    {
                        numsMatrix_1[j, i, kolTest] = rand.Next(2, 9);
                    }
                }
                for (byte i = 0; i < kolStolbik.Length; i++)
                {
                    for (byte j = 0; j < kolStroka.Length; j++)
                    {
                        numsMatrix_2[j, i, kolTest] = rand.Next(2, 9);
                    }
                }
            }
            classMethods.matrixSum_matrixMul(numsMatrix_1, numsMatrix_2, kolStolbik, kolStroka, 2);
        }

        static void Main(string[] args)
        {
            enter_lesson_1();
            enter_lesson_2();

            Console.ReadKey();
        }
    }
}