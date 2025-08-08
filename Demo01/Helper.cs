using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal static class Helper
    {
        public static void Swap<T>(ref T X, ref T Y)
        {
            T temp = X;
            X = Y;
            Y = temp;
        }

        public static int LinearSearch<T>(T[] Arr, T value)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                    if (Arr[i].Equals(value))
                        return i;

            }
            return -1;
        }

        public static int LinearSearch<T>(T[] Arr, T value, IEqualityComparer<T> equalityComparer)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                    if (equalityComparer.Equals(Arr[i], value))
                        return i;
            }

            return -1;
        }

        public static void BubbleSort<T>(T[] arr) where T : IComparable<T>
        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    bool isSwapped = false;

                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if (arr[j].CompareTo(arr[j + 1]) > 0)
                        {
                            Swap<T>(ref arr[j], ref arr[j + 1]);
                            isSwapped = true;
                        }
                    }

                    if (!isSwapped)
                    {
                        return;
                    }
                }
            }
        }


        public static void BubbleSort<T>(T[] arr, IComparer<T> comparer) where T : IComparable<T>
        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    bool isSwapped = false;

                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if (comparer.Compare(arr[j], arr[j + 1]) > 0)
                        {
                            Swap<T>(ref arr[j], ref arr[j + 1]);
                            isSwapped = true;
                        }
                    }

                    if (!isSwapped)
                    {
                        return;
                    }
                }
            }
        }

        public static void PrintArray<T>(T[] arr)
        {
            foreach (T item in arr)
            {
                Console.WriteLine(item);
            }
        }


    }
}
