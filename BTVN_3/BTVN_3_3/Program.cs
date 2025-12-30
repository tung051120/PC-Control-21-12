namespace BTVN_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tong = 0;
            for (int i = 1; i <= n; i++)
            {
                tong+= i;

            }
            Console.WriteLine(tong);
        }
    }
}
