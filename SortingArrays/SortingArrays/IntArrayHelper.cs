using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArrays
{
    public class IntArrayHelper
    {
        public void Sort(int[] intArray)
        {
            // Implementation from https://www.c-sharpcorner.com/blogs/sort-array-in-c-sharp-without-using-inbuilt-function
            int temp = 0;

            for (int i = 0; i <= intArray.Length; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
        }

        public void Reverse(int[] intArray)
        {
            // Implementation from https://stackoverflow.com/questions/6088287/reverse-an-array-without-using-array-reverse
            Sort(intArray);

            for (int i = 0; i < intArray.Length / 2; i++)
            {
                int tmp = intArray[i];
                intArray[i] = intArray[intArray.Length - i - 1];
                intArray[intArray.Length - i - 1] = tmp;
            }
        }
    }
}
