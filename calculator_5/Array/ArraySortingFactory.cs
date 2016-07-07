using System;

namespace calculator_5.Array
{
    public static class ArraySortingFactory
    {
        /// <summary>
        /// This is factory for working with array
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IArraySorting CreateSorter(string name)
        {
            switch(name)
            {
                case "button_array":
                    return new BubbleSorting();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}