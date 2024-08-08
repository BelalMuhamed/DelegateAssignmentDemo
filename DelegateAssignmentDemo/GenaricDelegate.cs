using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssignmentDemo
{
    public delegate bool Comapre<T>(T num1,T num2);
    internal class GenaricDelegate
    {
        public static void BubbleSort<T>(T[] arr,Comapre<T> reference )
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (reference(arr[j], arr[j + 1]))
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        private static void Swap<T>(ref T num, ref T num2)
        {
            T temp =num;
           num = num2;
            num2 = temp;
        }
        public static bool SortAsending(string st,string st2) { return st.Length > st2.Length; }
        public static bool SortDesending(string st, string st2) { return st.Length < st2.Length; }
        public static bool Greater(int  num1, int num2) { return num1 > num2; }
        public static bool Less(int num1, int num2) { return num1 > num2; }




    }
}
