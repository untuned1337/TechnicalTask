using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static List<int> GetLuckyNumbers(List<int> Integers) {
            List<int> FilteredList = new List<int>();
            if (Integers[0] % 2 == 0) // if first number is even
            {
                FilteredList = Integers.Select(n => n).Where(n => n % 2 != 0).ToList<int>(); // remove odd numbers
            }
            else { // if first number is odd
                FilteredList = Integers.Select(n => n).Where(n => n % 2 == 0).ToList<int>(); // remove even numbers
            }

            List<int> TempList; // to avoid problems when deleting from a list in a loop
            for (int i = 1; i < FilteredList.Count; i++)
            {
                TempList = FilteredList;
                if (FilteredList[i] <= FilteredList.Count) // if current cumber isn't larger than List's element count
                {
                    // Remove every List[i]-ith element from the list
                    for (int j = FilteredList[i]; j < FilteredList.Count; j += FilteredList[i])
                    {
                        TempList.RemoveAt(FilteredList[i] - 1);
                    }
                }
                else {
                    break; // stop the method
                }

                FilteredList = TempList; // assign the value to the Filtered list
            }

            return FilteredList;
        }

    }
}
