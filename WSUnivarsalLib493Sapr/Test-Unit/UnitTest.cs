using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.UnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WSUnivarsalLib;

namespace Test_Unit
{
    [TestClass]
    public class UnitTest
    {
        Calculator calculator = new Calculator();

        [TestMethod]
        public void GetQuantityForProduct_PositivnieTest()
        {
            int prodTest = 3;
            int matrTest = 1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            int expeResult = 150549;
            int actualResult = calculator.GetQuantityForProduct(prodTest, matrTest, countTest, widthTest, lengthTest);
            Assert.AreEqual(expeResult, actualResult);

        }

        [TestMethod]
        public void GetQuantityForProduct_NoExistentProduct()
        {
            int prodTest = -3;
            int matrTest = 1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            int expeResult = -1;
            int actualResult = calculator.GetQuantityForProduct(prodTest, matrTest, countTest, widthTest, lengthTest);
            Assert.AreEqual(expeResult, actualResult);

        }

        [TestMethod]
        public void GetQuantityForProduct_NoExistentMaterial()
        {
            int prodTest = 3;
            int matrTest = -1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            int expeResult = -1;
            int actualResult = calculator.GetQuantityForProduct(prodTest, matrTest, countTest, widthTest, lengthTest);
            Assert.AreEqual(expeResult, actualResult);

        }

        [TestMethod]
        public void GetQuantityForProduct_NoExistentCount()
        {
            int prodTest = 3;
            int matrTest = -1;
            int countTest = -15;
            float widthTest = 20;
            float lengthTest = 45;

            int expeResult = -1;
            int actualResult = calculator.GetQuantityForProduct(prodTest, matrTest, countTest, widthTest, lengthTest);
            Assert.AreEqual(expeResult, actualResult);

        }

        [TestMethod]
        public void GetQuantityForProduct_NoExistentWidth()
        {
            int prodTest = 3;
            int matrTest = 1;
            int countTest = 15;
            float widthTest = -20;
            float lengthTest = 45;

            int expeResult = -1;
            int actualResult = calculator.GetQuantityForProduct(prodTest, matrTest, countTest, widthTest, lengthTest);
            Assert.AreEqual(expeResult, actualResult);

        }

        [TestMethod]
        public void GetQuantityForProduct_NoExistentLength()
        {
            int prodTest = 3;
            int matrTest = 1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = -45;

            int expeResult = -1;
            int actualResult = calculator.GetQuantityForProduct(prodTest, matrTest, countTest, widthTest, lengthTest);
            Assert.AreEqual(expeResult, actualResult);

        }

        [TestMethod]
        public void GetQuantityForProduct_CoefficientProduct_1()
        {
            int prodTest = 1;
            int matrTest = 1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            double expeResult = 48341;
            int actualResult = calculator.GetQuantityForProduct(prodTest, matrTest, countTest, widthTest, lengthTest);
            Assert.AreEqual(expeResult, actualResult);

        }

        [TestMethod]
        public void GetQuantityForProduct_CoefficientProduct_2()
        {
            int prodTest = 2;
            int matrTest = 1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            double expeResult = 34530;
            int actualResult = calculator.GetQuantityForProduct(prodTest, matrTest, countTest, widthTest, lengthTest);
            Assert.AreEqual(expeResult, actualResult);

        }

        [TestMethod]
        public void GetQuantityForProduct_CoefficientProduct_3()
        {
            int prodTest = 2;
            int matrTest = 1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            double expeResult = 34530;
            int actualResult = calculator.GetQuantityForProduct(prodTest, matrTest, countTest, widthTest, lengthTest);
            Assert.AreEqual(expeResult, actualResult);

        }

        [TestMethod]
        public void GetQuantityForProduct_CoefficientMaterial_1()
        {
            int prodTest = 3;
            int matrTest = 2;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            double expeResult = 150270;
            int actualResult = calculator.GetQuantityForProduct(prodTest, matrTest, countTest, widthTest, lengthTest);
            Assert.AreEqual(expeResult, actualResult);

        }

        [TestMethod]
        public void GetQuantityForProduct_CoefficientMaterial_2()
        {
            int prodTest = 3;
            int matrTest = 1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            double expeResult = 150549;
            int actualResult = calculator.GetQuantityForProduct(prodTest, matrTest, countTest, widthTest, lengthTest);
            Assert.AreEqual(expeResult, actualResult);

        }

        [TestMethod]
        public void GetQuantityForProduct_Ploshad()
        {
            int prodTest = 3;
            int matrTest = 1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            double expeResult = 150549;
            int actualResult = calculator.GetQuantityForProduct(prodTest, matrTest, countTest, widthTest, lengthTest);
            Assert.AreEqual(expeResult, actualResult);

        }

        [TestMethod]
        public void GetQuantityForProduct_NoLaunchClass()
        {
            int prodTest = 3;
            int matrTest = 1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            double expeResult = 0;
            
            Assert.AreEqual(expeResult, calculator.coefMatrType);

        }

        [TestMethod]
        public void GetQuantityForProduct_QualityRaw()
        {
            int prodTest = 3;
            int matrTest = 1;
            int countTest = 15;
            float widthTest = 20;
            float lengthTest = 45;

            double expeResult = 150549;
            int actualResult = calculator.GetQuantityForProduct(prodTest, matrTest, countTest, widthTest, lengthTest);
            Assert.AreEqual(expeResult, actualResult);

        }

        [TestMethod]
        public void GetQuantityForProduct_ConvertProduct()
        {
            float prodTypeFloat = 2.5f;

            int prodTest = 0;
            int matrTest = 1;
            int countTest = 15;
            float widthTest = 0;
            float lengthTest = 45;

            prodTest = Convert.ToInt32(prodTypeFloat);

            double expeResult = -1;
            int actualResult = calculator.GetQuantityForProduct(prodTest, matrTest, countTest, widthTest, lengthTest);
            Assert.AreEqual(expeResult, actualResult);

        }
    }
}
