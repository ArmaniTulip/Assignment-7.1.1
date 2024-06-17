namespace Assignment_7._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 100, 47, 72, 34, 65, 12, 97};
            SelectionSort(arr);
            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++) 
            Console.WriteLine(arr[i] + "");
            Console.WriteLine();
        }

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            int lastElement = n-1;

            for (int i = 0;i < lastElement; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;

                        
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
