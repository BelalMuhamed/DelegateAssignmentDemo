using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssignmentDemo
{
    public delegate bool check(int number);
    internal class CheckNumber
    {
        public static List<int> checkNumber(List<int> list,check reference)
        {
            List<int>Checked=new List<int>();   
            if(list is not null )
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (reference(list[i]))
                    {
                        Checked.Add(list[i]);
                    }
                }
            }
            
            return Checked;
        }
        public static bool Odd(int num) { return num%2 != 0; }
        public static bool Even(int num) { return num % 2 == 0; }
        public static bool DivisableBy4(int num) { return num % 4 == 0; }


    }
}
