using System;
using MathLib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mas = new double[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            double a = Arranges.ArrDet(mas); ;
        }
    }
}
