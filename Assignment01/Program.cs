using System.Collections;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            ///* 1. create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic
            //     * operations such as checking if a value is within the range and determining the length of the range.
            //     * Requirements:
            //     * 1.1. Create a generic class named Range<T> where T represents the type of values.
            //     * 1.2. Implement a constructor that takes the minimum and maximum values to define the range.
            //     * 1.3. Implement a method IsInRange(T value) that returns true if the given value is within the range, otherwise false.
            //     * 1.4. Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
            //     * 1.5. Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons. 
            //     */

            ////Testing Range of integer values
            //int min, max, value;

            //do
            //{
            //    Console.Write("Enter the min integer in range: ");
            //} while (!int.TryParse(Console.ReadLine(), out min));

            //do
            //{
            //    Console.Write("Enter the max integer in range: ");
            //} while (!int.TryParse(Console.ReadLine(), out max));

            //Range<int> rangeInt = new Range<int>(min, max);

            //do
            //{
            //    Console.Write("Enter an integer value to test: ");
            //} while (!int.TryParse(Console.ReadLine(), out value));

            //if (rangeInt.IsInRange(value))
            //    Console.WriteLine($"{value} is in range");

            //else
            //    Console.WriteLine($"{value} is not in range");

            //Console.WriteLine($"Length of range = {rangeInt.Length()}");
            #endregion

            #region Q02
            //2. You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place
            //   (in the same arrayList) without using the built-in Reverse.Implement a function thattakes the ArrayList as input and modifies it
            //   to have the reversed order ofelements. 
            int itemsNumber;
            do
            {
                Console.Write("Enter the number of items in the array list:");
            } while (!int.TryParse(Console.ReadLine(), out itemsNumber));            

            ArrayList arrayList = new ArrayList(itemsNumber);

            for (int i = 0; i < itemsNumber; i++)
            {
                Console.Write($"Enter the {i + 1}th item: ");
                arrayList.Add(Console.ReadLine());
            }

            Helper.ReverseArrayList(ref arrayList);

            Console.WriteLine("Array List After Reverse");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
