using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Tests {
	[TestClass()]
	public class LogicTests {
		[TestMethod()]
		public void GetResultTest() {
			int[] arr = { 1, 2, 3, 3, 4, 5, 6, 6, 7 };

			string str = Logic.GetResult(arr);

			Assert.AreEqual("3 7 ", str);
		}

		[TestMethod()]
		public void GetResultTest1() {
			int[] arr = { 55, 55, 55, 2, 5 };

			string str = Logic.GetResult(arr);

			Assert.AreEqual("1 ", str);
		}

		[TestMethod()]
		public void GetResultTest2() {
			int[] arr = { 0, 1, 1 };

			string str = Logic.GetResult(arr);

			Assert.AreEqual("2 ", str);
		}

		[TestMethod()]
		public void GetResultTest3() {
			int[] arr = { 9, 9 };

			string str = Logic.GetResult(arr);

			Assert.AreEqual("1 ", str);
		}

		[TestMethod()]
		public void GetResultTest4() {
			int[] arr = { 1, 1, 2, 2, 3, 3, 4, 4 };

			string str = Logic.GetResult(arr);

			Assert.AreEqual("1 3 5 7 ", str);
		}
	}
}