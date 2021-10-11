
using MathLib;

namespace ConsoleApp2
{
    public class classPath
    {
        public static string[] pathFiles_sumMul_averageGeomAverage = { @"\testSum.txt", @"\testMul.txt", @"\testAverage.txt", @"\test_geomAverage.txt" };
        public static string[] pathFiles_arrSort_arrFind_arrDet_matrixSum_matrixMul = { @"\testArrSort.txt", @"\testArrFind.txt", @"\testArrDet.txt", @"\testMatrixSum.txt", @"\testMatrixMul.txt" };

        public static string path { get; set; }

        public static byte maxValue { get; } = 20;
    }
}
