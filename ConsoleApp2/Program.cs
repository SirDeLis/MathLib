using System;
using System.Collections.Generic;
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
            double[,,] mas = new double[5,6,70] /*{ { 11, 2, 3, 4 }, { 5, 62, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } }*/;
            int a1 = mas.GetLength(0);
            int a2 = mas.GetLength(1);
            int a3 = mas.GetLength(2);
            //double a = Arranges.ArrDet(mas);
            //a = Convert.ToDouble(null);
            
        }
    }
}
