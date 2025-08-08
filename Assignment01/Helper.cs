using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal static class Helper
    {
        public static void ReverseArrayList(ref ArrayList arrayList)
        {
            ArrayList tempArrayList = new ArrayList(arrayList.Capacity);

            for (int i = 0; i < arrayList.Count; i++)
            {
                tempArrayList.Add(arrayList[arrayList.Count - i - 1]);
            }

            arrayList = tempArrayList;
        }

        public static List<int> GetEvenNumbers(List<int> numbersList)
        {
            List<int> tempList = new List<int>();

            foreach (var item in numbersList)
            {
                if (item % 2 == 0)
                {
                    tempList.Add(item);
                }
            }

            return tempList;
        }
    }
}
