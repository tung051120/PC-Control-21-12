using System.ComponentModel.Design;

namespace BTVN_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("moi nhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("so am");
            }
            else if (n > 0)
            {
                Console.WriteLine("so duong");
            }
            else
            {
                Console.WriteLine("so 0");
            }

        }
    }
}
