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
            ////2. You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place
            ////   (in the same arrayList) without using the built-in Reverse.Implement a function thattakes the ArrayList as input and modifies it
            ////   to have the reversed order ofelements. 
            //int itemsNumber;
            //do
            //{
            //    Console.Write("Enter the number of items in the array list:");
            //} while (!int.TryParse(Console.ReadLine(), out itemsNumber));            

            //ArrayList arrayList = new ArrayList(itemsNumber);

            //for (int i = 0; i < itemsNumber; i++)
            //{
            //    Console.Write($"Enter the {i + 1}th item: ");
            //    arrayList.Add(Console.ReadLine());
            //}

            //Helper.ReverseArrayList(ref arrayList);

            //Console.WriteLine("Array List After Reverse");

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q03
            //// 3.You are given a list of integers. Your task is to find and return a new list
            ////   containing only the even numbers from the given list.

            //int itemsNumber, number;

            //do
            //{
            //    Console.Write("Enter the number of items in the numbers list:");
            //} while (!int.TryParse(Console.ReadLine(), out itemsNumber));

            //List<int> numbersList = new List<int>(itemsNumber);

            //for (int i = 0; i < itemsNumber; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter the {i + 1}th number: ");
            //    } while (!int.TryParse(Console.ReadLine(), out number));

            //    numbersList.Add(number);
            //}

            //List<int> evenNumbers = Helper.GetEvenNumbers(numbersList);

            //Console.WriteLine("===============================================");
            //Console.WriteLine("List of even numbers");

            //foreach (var item in evenNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q04
            // 4. Implement a custom list called FixedSizeList<T> with a predeterminedcapacity.
            //    This list should not allow more elements than its capacity and should provide clear messages
            //    if one tries to exceed it or access invalid indices.
            // Requirements:
            // 4.1. Create a generic class named FixedSizeList<T>.
            // 4.2. Implement a constructor that takes the fixed capacity of the list as a parameter.
            // 4.3. Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
            // 4..4 Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.

            int capacity, tempItem, index;
            do
            {
                Console.Write("Enter the capacity  list: ");
            } while (!int.TryParse(Console.ReadLine(), out capacity));

            FixedSizeList<int> arrayList = new FixedSizeList<int>(capacity);

            for (int i = 0; i < capacity; i++)
            {
                do
                {
                    Console.Write($"Enter the {i + 1}th item: ");
                } while (!int.TryParse(Console.ReadLine(), out tempItem));

                arrayList.Add(tempItem);
            }

            do
            {
                Console.WriteLine("Enter the item idex you want to get");
            }
            while (!int.TryParse(Console.ReadLine(), out index));

            Console.WriteLine(arrayList.Get(index));

            //arrayList.Add(33); //Exception

            #endregion
        }
    }
}
