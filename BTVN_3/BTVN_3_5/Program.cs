namespace BTVN_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int tong = 0;
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    break;
                }
                else if (n%2==0)
                {
                    continue;
                }
                tong += n;
            }
            Console.WriteLine(tong);
        }
    }
}
