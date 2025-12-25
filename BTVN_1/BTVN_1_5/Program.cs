namespace BTVN_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // giai thich ve su khac biet ve do chinh xac giua float, double va decimal
            Console.WriteLine("---giai thich ve su khac biet ve do chinh xac giua float, double va decimal---");
            // float la he nhi phan 4 byte, do chinh xac khoang 7 chu so
            float floatValue = 1.1234567f;
            // double la he nhi phan 8 byte, do chinh xac khoang 15-16 chu so
            double doubleValue = 1.123456789012343;
            // decimal la he thap phan 16 byte, do chinh xac khoang 28-29 chu so
            decimal decimalValue = 1.12345678901234567890123345m;
            Console.WriteLine("Gia tri float: " + floatValue);
            Console.WriteLine("Gia tri double: " + doubleValue);
            Console.WriteLine("Gia tri decimal: " + decimalValue);
        }
    }
}
