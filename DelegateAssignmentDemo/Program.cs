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
        }
    }
}
