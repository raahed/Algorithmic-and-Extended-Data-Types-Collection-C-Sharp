﻿namespace Algorithmic_Collection
{
    public partial class Algorithm
    {
        private class HeapSortFunctions
        {
            private static int Parent(int i)
            {
                return i / 2;
            }

            private static int Left(int i)
            {
                return 2 * i;
            }

            private static int Right(int i)
            {
                return (i * 2) + 1;
            }
        }

        public static void HeapSort(int[] a)
        {
            if (a.Length < 2)
                return;
        }
    }
}
