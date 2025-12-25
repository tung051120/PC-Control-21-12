namespace BTVN_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // thu nghiem hien tuong over flow voi byte va sbyte
            Console.WriteLine("---thu nghiem hien tuong over flow voi byte va sbyte---");
            byte overFlow = 255;
            Console.WriteLine("Gia tri byte truoc khi over flow: " + overFlow);
            overFlow++;
            Console.WriteLine("Gia tri byte sau khi over flow: " + overFlow);
            sbyte overFlow2 = -128;
            Console.WriteLine("Gia tri sbyte truoc khi over flow: " + overFlow2);
            overFlow2--;
            Console.WriteLine("Gia tri sbyte sau khi over flow: " + overFlow2);
        }
    }
}
