using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Tests {
    [TestClass()]
    public class LogicTests {
        [TestMethod()]
        public void TheTrainStandsOnThePlatform() {
            string result = Logic.Conditions(10, 10,
                                             15, 30,
                                             12, 30);

            Assert.AreEqual("Поезд стоит на платформе", result);
        }

        [TestMethod()]
        public void TheTrainStandsOnThePlatform1() {
            string result = Logic.Conditions(10, 10,
                                             15, 30,
                                             14, 57);

            Assert.AreEqual("Поезд стоит на платформе", result);
        }

        [TestMethod()]
        public void TheTrainStandsOnThePlatform2() {
            string result = Logic.Conditions(23, 30,
                                              1, 30,
                                              0, 47);

            Assert.AreEqual("Поезд стоит на платформе", result);
        }

        [TestMethod()]
        public void TheTrainStandsOnThePlatform3() {
            string result = Logic.Conditions(23,  0,
                                              0,  0,
                                             23, 45);

            Assert.AreEqual("Поезд стоит на платформе", result);
        }

        [TestMethod()]
        public void TheTrainStandsOnThePlatform4() {
            string result = Logic.Conditions(17, 30,
                                              5, 45,
                                             19, 38);

            Assert.AreEqual("Поезд стоит на платформе", result);
        }

        [TestMethod()]
        public void TheTrainDontStandsOnThePlatform() {
            string result = Logic.Conditions(10, 10,
                                             15, 30,
                                             22, 35);

            Assert.AreEqual("Поезд не стоит на платформе", result);
        }

        [TestMethod()]
        public void TheTrainDontStandsOnThePlatform1()  {
            string result = Logic.Conditions(23, 0,
                                              0, 0,
                                              0, 5);

            Assert.AreEqual("Поезд не стоит на платформе", result);
        }

        [TestMethod()]
        public void TheTrainDontStandsOnThePlatform2() {
            string result = Logic.Conditions(23,  0,
                                              0, 15,
                                              0, 30);

            Assert.AreEqual("Поезд не стоит на платформе", result);
        }
    }
}