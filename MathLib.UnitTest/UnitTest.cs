using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathLib.UnitTest
{
    public class ArrayTestClass
    {
        protected double[] massiveOne = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9.5 };
        protected double[] massiveTwo = new double[] { };
        protected double[] massiveThree = new double[] { 1 };
        protected double[] massiveFour = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, -9.5 };
        protected double[] massiveFive = new double[] { -1 };
        protected double[] massiveSix = new double[] { 0 };
    }

    public class MatrixTestClass
    {
        protected double[,] massiveDoubleOne = new double[,] { { -1, 2, 3 }, { 4, -5, 6 }, { 7, -8, 9 } };
        protected double[,] massiveDoubleTwo = new double[,] { { 1, 2, 3, 1, 2 }, { 4, 5, 6, 1, 2 }, { 7, 8, 9, 1, 2 }, { 1, 2, 3, 1, 2 }, { 1, 2, 3, 1, 2 } };
        protected double[,] massiveDoubleThree = new double[,] { { 1 } };
        protected double[,] massiveDoubleFour = new double[,] { { } };
        protected double[,] massiveDoubleFive = new double[,] { { 1, 2 }, { 4, 5 } };
        protected double[,] massiveDoubleSix = new double[,] { { 1, 2, 3 }, { 4, 5, 6 } };
    }

    [TestClass]
    public class SumTestClass : ArrayTestClass
    {
        [TestMethod]
        public void SumCorrectArray() => Assert.AreEqual(45.5f, MathCl.Sum(massiveOne));
        [TestMethod]
        public void SumEmtyArray() => Assert.AreEqual(0, MathCl.Sum(massiveTwo));
        [TestMethod]
        public void SumCorrectArrayWithSingleElement() => Assert.AreEqual(1f, MathCl.Sum(massiveThree));
        [TestMethod]
        public void SumCorrectArrayWithDouble() => Assert.AreEqual(26.5f, MathCl.Sum(massiveFour));
        [TestMethod]
        public void SumCorrectArrayWithNegativeNumber() => Assert.AreEqual(-1f, MathCl.Sum(massiveFive));
        [TestMethod]
        public void SumArrayWithNull() => Assert.AreEqual(0f, MathCl.Sum(massiveSix));
    }

    [TestClass]
    public class MulTestClass : ArrayTestClass
    {

        [TestMethod]
        public void MulCorrectArray()                    => Assert.AreEqual(383040, MathCl.Mul(massiveOne));
        [TestMethod]
        public void MulEmtyArray()                       => Assert.AreEqual(1, MathCl.Mul(massiveTwo));
        [TestMethod]
        public void MulCorrectArrayWithSingleElement()   => Assert.AreEqual(1f, MathCl.Mul(massiveThree));
        [TestMethod]
        public void MulCorrectArrayWithDouble()          => Assert.AreEqual(-383040, MathCl.Mul(massiveFour));
        [TestMethod]
        public void MulCorrectArrayWithNegativeNumber()  => Assert.AreEqual(-1f, MathCl.Mul(massiveFive));
        [TestMethod]
        public void MulArrayWithNull()                   => Assert.AreEqual(0f, MathCl.Mul(massiveSix));
    }

    [TestClass]
    public class AverageTestClass : ArrayTestClass
    {
        [TestMethod]
        public void AverageCorrectArray()                   => Assert.AreEqual(5.05f, Math.Round(MathCl.Average(massiveOne), 2));
        [TestMethod]
        public void AverageEmtyArray()                      => Assert.AreEqual("не число", MathCl.Average(massiveTwo).ToString());
        [TestMethod]
        public void AverageCorrectArrayWithSingleElement()  => Assert.AreEqual(1f, MathCl.Average(massiveThree));
        [TestMethod]
        public void AverageCorrectArrayWithDouble()         => Assert.AreEqual(2.94f, Math.Round(MathCl.Average(massiveFour), 2));
        [TestMethod]
        public void AverageCorrectArrayWithNegativeNumber() => Assert.AreEqual(-1f, MathCl.Average(massiveFive));
        [TestMethod]
        public void AverageArrayWithNull()                  => Assert.AreEqual(0f, MathCl.Average(massiveSix));
    }
    [TestClass]
    public class GeomAverageTestClass : ArrayTestClass
    {
        [TestMethod]
        public void GeomAverageCorrectArray()                   => Assert.AreEqual(4.172, Math.Round(MathCl.GeomAverage(massiveOne), 3));
        [TestMethod]                                            
        public void GeomAverageEmtyArray()                      => Assert.AreEqual(1, MathCl.GeomAverage(massiveTwo));
        [TestMethod]                                            
        public void GeomAverageCorrectArrayWithSingleElement()  => Assert.AreEqual(1f, MathCl.GeomAverage(massiveThree));
        [TestMethod]                                            
        public void GeomAverageCorrectArrayWithDouble()         => Assert.AreEqual("не число", MathCl.GeomAverage(massiveFour).ToString());
        [TestMethod]                                            
        public void GeomAverageCorrectArrayWithNegativeNumber() => Assert.AreEqual(-1f, MathCl.GeomAverage(massiveFive));
        [TestMethod]                                            
        public void GeomAverageArrayWithNull()                  => Assert.AreEqual(0f, MathCl.GeomAverage(massiveSix));
    }
    [TestClass]
    public class ArrFindMaxTestClass : ArrayTestClass
    {
        [TestMethod]
        public void ArrFindMaxCorrectArray()                   => Assert.AreEqual(9.5f, Arranges.ArrFind(massiveOne, true)[0]);
        [TestMethod]                                           
        public void ArrFindMaxEmtyArray()                      => Assert.AreEqual(null, Arranges.ArrFind(massiveTwo, true)[0]);
        [TestMethod]                                           
        public void ArrFindMaxCorrectArrayWithSingleElement()  => Assert.AreEqual(1f, Arranges.ArrFind(massiveThree, true)[0]);
        [TestMethod]                                           
        public void ArrFindMaxCorrectArrayWithDouble()         => Assert.AreEqual(8.5f, Arranges.ArrFind(massiveFour, true)[0]);
        [TestMethod]                                           
        public void ArrFindMaxCorrectArrayWithNegativeNumber() => Assert.AreEqual(-1f, Arranges.ArrFind(massiveFive, true)[0]);
        [TestMethod]                                           
        public void ArrFindMaxArrayWithNull()                  => Assert.AreEqual(0f, Arranges.ArrFind(massiveSix, true)[0]);
    }
    [TestClass]
    public class ArrFindMinTestClass : ArrayTestClass
    {
        [TestMethod]
        public void ArrFindMinCorrectArray()                   => Assert.AreEqual(1f, Arranges.ArrFind(massiveOne, false)[0]);
        [TestMethod]
        public void ArrFindMinEmtyArray()                      => Assert.AreEqual(null, Arranges.ArrFind(massiveTwo, false)[0]);
        [TestMethod]                                           
        public void ArrFindMinCorrectArrayWithSingleElement()  => Assert.AreEqual(1f, Arranges.ArrFind(massiveThree, false)[0]);
        [TestMethod]                                           
        public void ArrFindMinCorrectArrayWithDouble()         => Assert.AreEqual(-9.5f, Arranges.ArrFind(massiveFour, false)[0]);
        [TestMethod]                                           
        public void ArrFindMinCorrectArrayWithNegativeNumber() => Assert.AreEqual(-1f, Arranges.ArrFind(massiveFive, false)[0]);
        [TestMethod]                                           
        public void ArrFindMinArrayWithNull()                  => Assert.AreEqual(0f, Arranges.ArrFind(massiveSix, false)[0]);
    }
    [TestClass]
    public class ArrDetTestClass : MatrixTestClass
    {
        [TestMethod]
        public void ArrDetCorrect3x3Matrix() => Assert.AreEqual(18f, Arranges.ArrDet(massiveDoubleOne));
        [TestMethod]
        public void ArrDetCorrect5x5Matrix() => Assert.AreEqual(0, Arranges.ArrDet(massiveDoubleTwo));
        [TestMethod]
        public void ArrDetCorrect6x6Matrix() => Assert.AreEqual(0f, Arranges.ArrDet(massiveDoubleThree));
        [TestMethod]
        public void ArrDetEmtyMatrix()       => Assert.AreEqual(0f, Arranges.ArrDet(massiveDoubleFour));
        [TestMethod]
        public void ArrDetCorrect2x2Matrix() => Assert.AreEqual(-3, Arranges.ArrDet(massiveDoubleFive));
        [TestMethod]
        public void ArrDet2x3Matrix()        => Assert.AreEqual(0, Arranges.ArrDet(massiveDoubleSix));
    }

    [TestClass]
    public class ArrSortGrowingTestClass : ArrayTestClass
    {
        [TestMethod]
        public void ArrSortGrowingCorrectArray()                    => Assert.AreEqual(45.5f, Arranges.ArrSort(massiveOne, true)[0]);
        [TestMethod]
        public void ArrSortGrowingEmtyArray()                       => Assert.AreEqual(null, Arranges.ArrSort(massiveTwo, true)[0]);
        [TestMethod]
        public void ArrSortGrowingCorrectArrayWithSingleElement()   => Assert.AreEqual(1, Arranges.ArrSort(massiveThree, true)[0]);
        [TestMethod]
        public void ArrSortGrowingCorrectArrayWithDouble()          => Assert.AreEqual(26.5f, Arranges.ArrSort(massiveFour, true)[0]);
        [TestMethod]
        public void ArrSortGrowingCorrectArrayWithNegativeNumber()  => Assert.AreEqual(-1, Arranges.ArrSort(massiveFive, true)[0]);
        [TestMethod]
        public void ArrSortGrowingArrayWithNull()                   => Assert.AreEqual(0, Arranges.ArrSort(massiveSix, true)[0]);
    }
    [TestClass]
    public class ArrSortDescedingTestClass : ArrayTestClass
    {
        [TestMethod]
        public void ArrSortDescedingCorrectArray()                    => Assert.AreEqual(45.5f, Arranges.ArrSort(massiveOne, false)[0]);
        [TestMethod]
        public void ArrSortDescedingEmtyArray()                       => Assert.AreEqual(0, Arranges.ArrSort(massiveTwo, false)[0]);
        [TestMethod]
        public void ArrSortDescedingCorrectArrayWithSingleElement()   => Assert.AreEqual(1, Arranges.ArrSort(massiveThree, false)[0]);
        [TestMethod]
        public void ArrSortDescedingCorrectArrayWithDouble()          => Assert.AreEqual(26.5f, Arranges.ArrSort(massiveFour, false)[0]);
        [TestMethod]
        public void ArrSortDescedingCorrectArrayWithNegativeNumber()  => Assert.AreEqual(-1, Arranges.ArrSort(massiveFive, false)[0]);
        [TestMethod]
        public void ArrSortDescedingArrayWithNull()                   => Assert.AreEqual(0, Arranges.ArrSort(massiveSix, false)[0]);
    }
}
