namespace BTVN_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array co ban
            int[] arr = new int[5];
            for (int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i=0;i<arr.Length;i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
