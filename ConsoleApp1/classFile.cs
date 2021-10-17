using System.IO;

namespace ConsoleApp2
{
    class classFile : classPath
    {
        public static void pasteFiles_sumMul_averageGeomAverage(double[] nums, double answers, byte variantMethod, byte[] kol)
        {
            if (variantMethod == 1)
            {
                path = Directory.GetCurrentDirectory() + pathFiles_sumMul_averageGeomAverage[0];
                if (!File.Exists(path))
                {
                    var file = File.Create(path);
                    file.Close();
                }
                for (byte i = 0; i < kol.Length; i++)
                {
                    File.AppendAllText(path, nums[i] + "\t");
                }
                File.AppendAllText(path, "\nСумма => " + answers + "\n");
            }
            if (variantMethod == 2)
            {
                path = Directory.GetCurrentDirectory() + pathFiles_sumMul_averageGeomAverage[1];
                if (!File.Exists(path))
                {
                    var file = File.Create(path);
                    file.Close();
                }

                for (byte i = 0; i < kol.Length; i++)
                {
                    File.AppendAllText(path, nums[i] + "\t");
                }
                File.AppendAllText(path, "\nУмножение: => " + answers + "\n");
            }
            if (variantMethod == 3)
            {
                path = Directory.GetCurrentDirectory() + pathFiles_sumMul_averageGeomAverage[2];
                if (!File.Exists(path))
                {
                    var file = File.Create(path);
                    file.Close();
                }

                for (byte i = 0; i < kol.Length; i++)
                {
                    File.AppendAllText(path, nums[i] + "\t");
                }
                File.AppendAllText(path, "\nAverage => " + answers + "\n");
            }
            if (variantMethod == 4)
            {
                path = Directory.GetCurrentDirectory() + pathFiles_sumMul_averageGeomAverage[3];
                if (!File.Exists(path))
                {
                    var file = File.Create(path);
                    file.Close();
                }

                for (byte i = 0; i < kol.Length; i++)
                {
                    File.AppendAllText(path, nums[i] + "\t");
                }
                File.AppendAllText(path, "\nGeomAverage => " + answers + "\n");
            }
        }

        public static void pasteFile_arrSort_arrFind(double[] nums, double[] answers, byte[] kol, byte variantMethod)
        {
            if (variantMethod == 1)
            {
                path = Directory.GetCurrentDirectory() + pathFiles_arrSort_arrFind_arrDet_matrixSum_matrixMul[0];
                if (!File.Exists(path))
                {
                    var file = File.Create(path);
                    file.Close();
                }
                for (byte i = 0; i < kol.Length; i++)
                {
                    File.AppendAllText(path, nums[i] + "\t");
                }
                File.AppendAllText(path, "\n");
                File.AppendAllText(path, "Сортировка: " + "\n");
                for (byte i = 0; i < kol.Length; i++)
                {
                    File.AppendAllText(path, answers[i] + "\t");
                }
                File.AppendAllText(path, "\n");
            }
            if (variantMethod == 2)
            {
                path = Directory.GetCurrentDirectory() + pathFiles_arrSort_arrFind_arrDet_matrixSum_matrixMul[1];
                if (!File.Exists(path))
                {
                    var file = File.Create(path);
                    file.Close();
                }
                for (byte i = 0; i < kol.Length; i++)
                {
                    File.AppendAllText(path, nums[i] + "\t");
                }
                File.AppendAllText(path, "\n");
                File.AppendAllText(path, "\nArrFind: \n");
                for (byte i = 0; i < kol.Length; i++)
                {
                    File.AppendAllText(path, answers[i] + "\t");
                }
                File.AppendAllText(path, "\n");
            }
        }

        public static void pasteFile_arrDet(double[,] nums, double answer, byte[] kolStolbik, byte[] kolStroka)
        {
            path = Directory.GetCurrentDirectory() + pathFiles_arrSort_arrFind_arrDet_matrixSum_matrixMul[2];
            for (byte i = 0; i < kolStolbik.Length; i++)
            {
                for (byte j = 0; j < kolStroka.Length; j++)
                {
                    File.AppendAllText(path, nums[j,i] + "\t");
                }
                File.AppendAllText(path, "\n");
            }

            File.AppendAllText(path, "\nArrDet => " + answer);
        }

        public static void pasteFile_matrixSum_matrixMul(double[,] nums1, double[,] nums2, double[,] answer, byte[] kolStolbik, byte[] kolStroka, byte variantMethod)
        {
            if (variantMethod == 1)
            {
                path = Directory.GetCurrentDirectory() + pathFiles_arrSort_arrFind_arrDet_matrixSum_matrixMul[3];
                for (byte i = 0; i < kolStolbik.Length; i++)
                {
                    for (byte j = 0; j < kolStroka.Length; j++)
                    {
                        File.AppendAllText(path, nums1[j, i] + " ");
                    }
                    File.AppendAllText(path, "\n");
                }
                File.AppendAllText(path, "\n");
                for (byte i = 0; i < kolStolbik.Length; i++)
                {
                    for (byte j = 0; j < kolStroka.Length; j++)
                    {
                        File.AppendAllText(path, nums2[j, i] + " ");
                    }
                    File.AppendAllText(path, "\n");
                }
                File.AppendAllText(path, "\n");
                File.AppendAllText(path, "Сумма: \n");
                for (byte i = 0; i < kolStolbik.Length; i++)
                {
                    for (byte j = 0; j < kolStroka.Length; j++)
                    {
                        File.AppendAllText(path, answer[j, i] + " ");
                    }
                    File.AppendAllText(path, "\n");
                }
                File.AppendAllText(path, "\n");
            }
            if (variantMethod == 2)
            {
                path = Directory.GetCurrentDirectory() + pathFiles_arrSort_arrFind_arrDet_matrixSum_matrixMul[4];
                for (byte i = 0; i < kolStolbik.Length; i++)
                {
                    for (byte j = 0; j < kolStroka.Length; j++)
                    {
                        File.AppendAllText(path, nums1[j, i] + " ");
                    }
                    File.AppendAllText(path, "\n");
                }
                File.AppendAllText(path, "\n");
                for (byte i = 0; i < kolStolbik.Length; i++)
                {
                    for (byte j = 0; j < kolStroka.Length; j++)
                    {
                        File.AppendAllText(path, nums2[j, i] + " ");
                    }
                    File.AppendAllText(path, "\n");
                }
                File.AppendAllText(path, "\n");
                for (byte i = 0; i < kolStolbik.Length; i++)
                {
                    for (byte j = 0; j < kolStroka.Length; j++)
                    {
                        File.AppendAllText(path, answer[j, i] + "\t");
                    }
                    File.AppendAllText(path, "\n");
                }
                File.AppendAllText(path, "\n");
            }
        }
    }
}