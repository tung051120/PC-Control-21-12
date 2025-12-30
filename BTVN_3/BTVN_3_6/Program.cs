namespace BTVN_3_6
{
    internal class Program
    {
        static bool isPrime(int n)
        {
            
            if (n < 2)
            return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());           
            Console.WriteLine(isPrime(n).ToString().ToLower());
        }
    }
}
