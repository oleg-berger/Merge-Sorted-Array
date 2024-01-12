using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Merge();
        }
        static void Merge()
        {
            
            Console.Write("Enter m number: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num 1: ");
            int[] nums1 = EnterArray();

            Console.Write("Enter n number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num 2: ");
            string array = Console.ReadLine();
            string[] arrayStr = array.Split(' ');
            int[] nums2 = new int[n];
            for (int i = 0; i < arrayStr.Length; i++)
            {
                nums2[i] = Convert.ToInt32(arrayStr[i]);
            }


            int[] finalNum = SumArray(nums1, nums2, m, n);
            foreach ( var item in finalNum)
            {
                Console.Write(item + " ");
            }

        }

        static int[] EnterArray()
        {
            string array = Console.ReadLine();
            string[] arrayStr = array.Split(' ');
            int[] arrayInt = new int[arrayStr.Length];
            for (int i = 0; i < arrayStr.Length; i++)
            {
                arrayInt[i] = Convert.ToInt32(arrayStr[i]);
            }
            return arrayInt;
        }

        static int[] SumArray(int[] nums1, int[] nums2, int m, int n)
        {
            int[] exclusiveNums1 = new int[m];                                                                        


            if (nums1.Length > m)
            {
                exclusiveNums1 = nums1.Take(m).ToArray();
            }
            else
            {
                exclusiveNums1 = nums1;
            }

            

            int[] sumArray = exclusiveNums1.Concat(nums2).ToArray();
           

            Array.Sort(sumArray);

            return sumArray;

        }

    }
}
