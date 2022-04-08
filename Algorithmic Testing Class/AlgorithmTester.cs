﻿using System;

namespace Algorithmic_Tests
{
    public class AlgorithmicTester
    {
        private static readonly int _arrayLength = 999;

        private static int[] _sorted;
        private static int[] _unsorted;

        protected static int[] Sorted
        {
            get
            {
                return (int[])_sorted.Clone();
            }
        }
        protected static int[] Unsorted
        {
            get
            {
                return (int[])_unsorted.Clone();
            }
        }

        static AlgorithmicTester()
        {
            Random random = new Random();

            _unsorted = new int[_arrayLength];

            for (int i = 0; i < _unsorted.Length; i++)
                _unsorted[i] = random.Next(1, 1000);

            _sorted = (int[])_unsorted.Clone();

            Array.Sort(_sorted);
        }

        static public void executeTest(Algorithmic_Collection.Algorithm)
        {

        }

        static protected bool IsEqual(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
                return false;

            int counter = 0;

            for (int i = 0; i < array1.Length; i++)
                if (array1[i] != array2[i])
                    counter++;

            if(counter != 0)
                throw new FormatException($"Probably {counter} of {array1.Length} elements are not at the correct position!");

            return true;
        }
    }
}