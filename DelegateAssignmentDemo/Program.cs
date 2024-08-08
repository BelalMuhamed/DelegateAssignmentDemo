namespace DelegateAssignmentDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region V03

            int[] arr = { 7, 6, 5, 8, 2, 3, 9, 10, 55, 4 };
            SortingArray.BubbleSort(arr, SortingArray.MethodGreater);
            foreach (int i in arr) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("***********************************************");
            SortingArray.BubbleSort(arr,SortingArray.MethodLess);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            #endregion


            #region v04
            int[] arr02 = { 7, 6, 5, 8, 2, 3, 9, 10, 55, 4 };
            string[] arr03 = { "Ahmed", "Ali", "Kayaan", "k", "KI", "Kill" };
            GenaricDelegate.BubbleSort(arr02, GenaricDelegate.Greater);
            foreach (var i in arr02)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("***********************************************");
            GenaricDelegate.BubbleSort(arr02, GenaricDelegate.Less);

            foreach (var i in arr02)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("***********************************************");
            GenaricDelegate.BubbleSort(arr03, GenaricDelegate.SortAsending);

            foreach (var i in arr03)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("***********************************************");
            GenaricDelegate.BubbleSort(arr03, GenaricDelegate.SortDesending);

            foreach (var i in arr03)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region v05
            Console.Clear();
            List<int> list = Enumerable.Range(1,100).ToList();
            List<int> checkedlist = new List<int>();
            check check= CheckNumber.Even;
            checkedlist=CheckNumber.checkNumber(list, check);
            foreach(var i in checkedlist)
            {
                Console.Write($"{i}  ");
               
            }
            Console.WriteLine("***********************************************************************");
             check = CheckNumber.Odd;
            checkedlist = CheckNumber.checkNumber(list, check);
            foreach (var i in checkedlist)
            {
                Console.Write($"{i}  ");

            }
            Console.WriteLine("***********************************************************************");
            check = CheckNumber.DivisableBy4;
            checkedlist = CheckNumber.checkNumber(list, check);
            foreach (var i in checkedlist)
            {
                Console.Write($"{i}  ");

            }
            #endregion

            #region v06
            List<int>filtered = list.Where((n) => n % 2 == 0).ToList();
            filtered = list.Where(delegate (int n) { return n % 2 == 0; }).ToList();

            #endregion
        }
    }
}
