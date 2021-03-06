﻿using calculator_5.Array;
using NUnit.Framework;

namespace calculator_5.Tests.Array
{
    [TestFixture]
    public class ArraySortingTest
    {
        public void SortTest()
        {
            int[] array = {1, -2, 3, 6, 5, 4, -8, 12};
            int[] expectedArray = {-8, -2, 1, 3, 4, 5, 6, 12};
            IArraySorting sorter = new BubbleSorting();
            array = sorter.Sorting(array);
            Assert.AreEqual(expectedArray,array);
        }
    }
}