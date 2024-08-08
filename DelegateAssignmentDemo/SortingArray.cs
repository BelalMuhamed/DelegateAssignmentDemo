using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssignmentDemo
{
    public delegate bool SortMethod(int num1, int num2);
    internal class SortingArray
    {
        public static void BubbleSort(int[]arr,SortMethod reference)
        {
            for (int i = 0; i < arr.Length; i++) 
            {
                for(int j = 0;j<arr.Length-i-1;j++)
                {
                    if (reference(arr[j], arr[j + 1]))
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        private static void Swap(ref int num1, ref int  num2) 
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            
        }
        public static  bool MethodGreater(int num1, int num2)
        {
            return (num1 > num2);
        }
        public static bool MethodLess(int num1, int num2)
        {
            return (num1 < num2);
        }
    }
}
