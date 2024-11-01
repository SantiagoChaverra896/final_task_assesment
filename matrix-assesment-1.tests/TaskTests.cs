using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional2Tasks.Tests
{
    [TestFixture]
    public class TaskTests
    {
        [Test]
        [TestCaseSource(nameof(TestCaseData))]
        public void Task_ReturnsCorrectValue(int[,] matrix, int[] expected)
        {
            var actual = Tasks.Task(matrix);
            Assert.True(actual.SequenceEqual(expected), "Task returns incorrect value[].");
        }

        public static IEnumerable<object[]> TestCaseData()
        {
            yield return new object[]
                { new int[,] { { 1, 0, 5 },
                           { 1, 3, 3 },
                           { 1, 5 ,6 } },
                  new int[] {3, 8, 14}                
                };
            yield return new object[]
                { new int[,] { { -1, 0, 3 },
                               { 5, 9, 0 },
                               { 4, 3, 3 } },
                  new int[] {8, 12, 6}
                };
            yield return new object[]
                {
                  new int[,] { { 0, 1, 3 },
                               { 4, 3, 3 },
                               { 3, 5, 3 } },
                  new int[] {7, 9, 9}
                };
        }
    }
}
