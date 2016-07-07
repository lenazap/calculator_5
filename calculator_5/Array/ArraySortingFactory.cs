using System;

namespace calculator_5.Array
{
    public static class ArraySortingFactory
    {
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