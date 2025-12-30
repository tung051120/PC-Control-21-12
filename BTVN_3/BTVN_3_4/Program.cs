using System.Runtime.InteropServices;

namespace BTVN_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            int []arr= new int[n];
            int Soduong=0;
            int Soam = 0;
            int Sokhong=0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(inputs[i]);
                if (arr[i] > 0)
                {
                    Soduong++;
                }
                else if (arr[i] < 0)
                {
                    Soam++;
                }
                else
                {
                    Sokhong++;
                }

            }
            Console.WriteLine("So duong: " + Soduong);
            Console.WriteLine("So am: " + Soam);
            Console.WriteLine("So khong: " + Sokhong);
        }
    }
}
