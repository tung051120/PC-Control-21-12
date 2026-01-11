using System.Runtime.InteropServices;

namespace BTVN_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array voi for loop
            int n = int.Parse(Console.ReadLine());           
            string Input = Console.ReadLine();
            string[] InputArr = Input.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            n=InputArr.Length;
            int[] arr = new int[n];
            for (int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(InputArr[i]);
            }
            int max = arr[0];
            int min = arr[0];
            double tong = 0;
            for (int i=0;i<arr.Length;i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            }
            for (int i=0;i<arr.Length;i++)
            {
                tong+=arr[i];
            }
            Array.Reverse(arr);
            Console.WriteLine($"{min} {max}");
            Console.WriteLine(tong/n);
            for(int i=0; i<arr.Length;i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
