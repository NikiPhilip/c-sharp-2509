using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ArraysandStrings
{
    public class Array_Calculations
    {
        public double FindMedian(int[] array)
        {
            int n = array.Length;
            if (n % 2 != 0)
            {
                return array[n / 2];
            }
            else
            {
                return (array[(n / 2) - 1] + array[n / 2]) / 2.0;
            }
        }
        public int FindMode(int[] array)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int element in array)
            {
                if (frequency.ContainsKey(element))
                    frequency[element]++;
                else
                    frequency[element] = 1;
            }

            int maxFrequency = frequency.Values.Max();
            return frequency.First(x => x.Value == maxFrequency).Key;

        }

        public void FindHighestAndSecondHighest(int[] array, out int highest, out int secondHighest)
        {
            highest = secondHighest = int.MinValue;

            foreach (int element in array)
            {
                //Finding the highest and second highest element by checking the array elements
                if (element > highest)
                {
                    secondHighest = highest;
                    highest = element;
                }
                else if (element > secondHighest && element != highest)
                {
                    secondHighest = element;
                }
            }
        }
        public List<int> FindDuplicates(int[] array)
        {
            //Hash set to store each unique element
            HashSet<int> seen = new HashSet<int>();
            List<int> duplicates = new List<int>();

            foreach (int element in array)
            {
                if (seen.Contains(element) && !duplicates.Contains(element))
                {
                    duplicates.Add(element);
                }
                else
                {
                    seen.Add(element);
                }
            }

            return duplicates;
        }
    }
}
