using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructVector3DLibrary;

namespace VectorUnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void CreateAndEqualsTest()
        {
            var vector = new Vector3D(10, 5, 5);
            Assert.AreEqual("Вектор с координатами: X: 10, Y: 5, Z: 5.", vector.ToString());

            var vector2 = new Vector3D(10, 5, 5);
            var vector3 = new Vector3D(5, 10, 5);

            Assert.AreEqual(true, vector.Equals(vector2));
            Assert.AreEqual(false, vector.Equals(vector3));
            Assert.AreEqual(false, vector.Equals(3.14));


            Assert.AreEqual(true, vector.GetHashCode() == vector2.GetHashCode());
            Assert.AreEqual(false, vector.GetHashCode() == vector3.GetHashCode());
        }

        [TestMethod]
        public void OperationsTest()
        {
            var vector = new Vector3D(10, 5, 5);
            var vector2 = new Vector3D(10, 5, 5);

            var vectorPlus = vector + vector2;
            var vectorResult = new Vector3D ( 20, 10, 10 );
            Assert.AreEqual(vectorResult, vectorPlus);

            vectorPlus -= vector;
            vectorResult = new Vector3D(10, 5, 5);
            Assert.AreEqual(vectorResult, vectorPlus);

            vectorPlus *= 0;
            vectorResult = new Vector3D(0, 0, 0);
            Assert.AreEqual(vectorResult, vectorPlus);
        }
    }
}
