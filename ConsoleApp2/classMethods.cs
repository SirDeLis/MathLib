using System;
using MathLib;

namespace ConsoleApp2
{
    class classMethods : classFile
    {
        private static double answerSum(double[] nums)
        {
            return MathCl.Sum(nums);
        }

        private static double answerMul(double[] nums)
        {
            return MathCl.Mul(nums);
        }

        private static double answerAverage(double[] nums)
        {
            return MathCl.Average(nums);
        }

        private static double answerGeomAverage(double[] nums)
        {
            return MathCl.GeomAverage(nums);
        }

        public static void lessons_1(double[,] numbers, byte[] kol, byte variantMethod)
        {
            double[] nums = new double[maxValue];
            if (variantMethod == 1)
            {
                for (byte kolTest = 0; kolTest < maxValue; kolTest++)
                {
                    for (byte i = 0; i < kol.Length; i++)
                    {
                        nums[i] = numbers[i, kolTest];
                        Console.Write(nums[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Sum => " + answerSum(nums));
                    pasteFiles_sumMul_averageGeomAverage(nums, answerSum(nums), 1, kol);
                }
                Console.WriteLine();
            }
            if (variantMethod == 2)
            {
                for (byte kolTest = 0; kolTest < maxValue; kolTest++)
                {
                    for (byte i = 0; i < kol.Length; i++)
                    {
                        nums[i] = numbers[i, kolTest];
                        Console.Write(nums[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Mul => " + answerMul(nums));
                    pasteFiles_sumMul_averageGeomAverage(nums, answerMul(nums), 2, kol);
                }
                Console.WriteLine();
            }
            if (variantMethod == 3)
            {
                for (byte kolTest = 0; kolTest < maxValue; kolTest++)
                {
                    for (byte i = 0; i < kol.Length; i++)
                    {
                        nums[i] = numbers[i, kolTest];
                        Console.Write(nums[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Average => " + answerAverage(nums));
                    pasteFiles_sumMul_averageGeomAverage(nums, answerAverage(nums), 3, kol);
                }
                Console.WriteLine();
            }
            if (variantMethod == 4)
            {
                for (byte kolTest = 0; kolTest < maxValue; kolTest++)
                {
                    for (byte i = 0; i < kol.Length; i++)
                    {
                        nums[i] = numbers[i, kolTest];
                        Console.Write(nums[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("GeomAverage => " + answerGeomAverage(nums));
                    pasteFiles_sumMul_averageGeomAverage(nums, answerGeomAverage(nums), 4, kol);
                }
                Console.WriteLine();
            }
        }

        private static void answer_arrSort(double[] nums, bool dir, byte[] kol)
        {
            double[] num = new double[maxValue];
            for (byte i = 0; i < nums.Length; i++)
            {
                num[i] = nums[i];
            }
            Arranges.ArrSort(nums, dir);
            {
                for (byte i = 0; i < kol.Length; i++)
                {
                    Console.Write("\t" + nums[i]);
                }
                pasteFile_arrSort_arrFind(num, nums, kol, 1);
            }
            Console.WriteLine();
        }

        private static void answer_arrFind(double[] nums, bool dir, byte[] kol)
        {
            double[] num = new double[maxValue];
            for (byte i = 0; i < nums.Length; i++)
            {
                num[i] = nums[i];
            }
            Arranges.ArrFind(nums, dir);
            {
                for (byte i = 0; i < kol.Length; i++)
                {
                    Console.Write("\t" + nums[i]);
                }
                pasteFile_arrSort_arrFind(num, nums, kol, 2);
            }
            Console.WriteLine();
        }

        private static double answer_arrDet(double[,] nums)
        {
            return Arranges.ArrDet(nums);
        }

        private static void answer_matrixSum(double[,] nums1, double[,] nums2, byte[] kolStolbik, byte[] kolStroka)
        {
            double[,] num1 = new double[maxValue, maxValue];
            double[,] num2 = new double[maxValue, maxValue];

            for (byte i = 0; i < kolStolbik.Length; i++)
            {
                for (byte j = 0; j < kolStroka.Length; j++)
                {
                    num1[j, i] = nums1[j, i];
                }
            }
            for (byte i = 0; i < kolStolbik.Length; i++)
            {
                for (byte j = 0; j < kolStroka.Length; j++)
                {
                    num2[j, i] = nums2[j, i];
                }
            }

            Arranges.MatrixSum(nums1, nums2);
            {
                for (byte i = 0; i < kolStolbik.Length; i++)
                {
                    for (byte j = 0; j < kolStroka.Length; j++)
                    {
                        Console.Write(nums1[j, i] + "\t");
                    }
                    Console.WriteLine("");
                }
                pasteFile_matrixSum_matrixMul(num1, num2, nums1, kolStolbik, kolStroka, 1);
                Console.WriteLine("");
            }
        }

        private static void answer_matrixMul(double[,] nums1, double[,] nums2, byte[] kolStolbik, byte[] kolStroka)
        {
            double[,] num1 = new double[maxValue, maxValue];
            double[,] num2 = new double[maxValue, maxValue];

            for (byte i = 0; i < kolStolbik.Length; i++)
            {
                for (byte j = 0; j < kolStroka.Length; j++)
                {
                    num1[j, i] = nums1[j, i];
                }
            }
            for (byte i = 0; i < kolStolbik.Length; i++)
            {
                for (byte j = 0; j < kolStroka.Length; j++)
                {
                    num2[j, i] = nums2[j, i];
                }
            }

            Arranges.MatrixMul(nums1, nums2);
            {
                for (byte i = 0; i < kolStolbik.Length; i++)
                {
                    for (byte j = 0; j < kolStroka.Length; j++)
                    {
                        Console.Write(nums1[j, i] + "\t");
                    }
                    Console.WriteLine("");
                }
                pasteFile_matrixSum_matrixMul(num1, num2, nums1, kolStolbik, kolStroka, 2);
                Console.WriteLine("");
            }
        }

        public static void arrSort_arrFind(double[,] nums, byte[] kol, bool dir, byte variantMethods)
        {
            double[] numbers = new double[maxValue];

            if (variantMethods == 1)
            {
                for (byte kolTest = 0; kolTest < maxValue; kolTest++)
                {
                    for (byte i = 0; i < kol.Length; i++)
                    {
                        numbers[i] = nums[i, kolTest];
                        Console.Write(numbers[i] + " ");
                    }
                    Console.WriteLine("\nArrSort:");
                    answer_arrSort(numbers, dir, kol);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            if (variantMethods == 2)
            {
                for (byte kolTest = 0; kolTest < maxValue; kolTest++)
                {
                    for (byte i = 0; i < kol.Length; i++)
                    {
                        numbers[i] = nums[i, kolTest];
                        Console.Write(numbers[i] + " ");
                    }
                    Console.WriteLine("\nArrFind => ");
                    answer_arrFind(numbers, dir, kol);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        public static void arrDet(double[,,] nums, byte[] kolStolbik, byte[] kolStroka)
        {
            double[,] numbersMatrix = new double[maxValue, maxValue];

            for (byte kolTest = 0; kolTest < maxValue; kolTest++)
            {
                for (byte i = 0; i < kolStolbik.Length; i++)
                {
                    for (byte j = 0; j < kolStroka.Length; j++)
                    {
                        numbersMatrix[j, i] = nums[j, i, kolTest];
                        Console.Write(numbersMatrix[j, i] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("\nArrDet => " + answer_arrDet(numbersMatrix));
                pasteFile_arrDet(numbersMatrix, answer_arrDet(numbersMatrix), kolStolbik, kolStroka);
            }
        }
        public static void matrixSum_matrixMul(double[,,] nums1, double[,,] nums2, byte[] kolStolbik, byte[] kolStroka, byte variantMethods)
        {
            double[,] numbersMatrix_1 = new double[maxValue, maxValue];
            double[,] numbersMatrix_2 = new double[maxValue, maxValue];

            if (variantMethods == 1)
            {
                for (byte kolTest = 0; kolTest < maxValue; kolTest++)
                {
                    for (byte i = 0; i < kolStolbik.Length; i++)
                    {
                        for (byte j = 0; j < kolStroka.Length; j++)
                        {
                            numbersMatrix_1[j, i] = nums1[j, i, kolTest];
                            Console.Write(numbersMatrix_1[j, i] + "\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    for (byte i = 0; i < kolStolbik.Length; i++)
                    {
                        for (byte j = 0; j < kolStroka.Length; j++)
                        {
                            numbersMatrix_2[j, i] = nums2[j, i, kolTest];
                            Console.Write(numbersMatrix_2[j, i] + "\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("MatrixSum:");
                    answer_matrixSum(numbersMatrix_1, numbersMatrix_2, kolStolbik, kolStroka);
                }
            }
            if (variantMethods == 2)
            {
                for (byte kolTest = 0; kolTest < maxValue; kolTest++)
                {
                    for (byte i = 0; i < kolStolbik.Length; i++)
                    {
                        for (byte j = 0; j < kolStroka.Length; j++)
                        {
                            numbersMatrix_1[j, i] = nums1[j, i, kolTest];
                            Console.Write(numbersMatrix_1[j, i] + "\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    for (byte i = 0; i < kolStolbik.Length; i++)
                    {
                        for (byte j = 0; j < kolStroka.Length; j++)
                        {
                            numbersMatrix_2[j, i] = nums2[j, i, kolTest];
                            Console.Write(numbersMatrix_2[j, i] + "\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("MatrixMul:");
                    answer_matrixMul(numbersMatrix_1, numbersMatrix_2, kolStolbik, kolStroka);
                }
            }
        }
    }
}