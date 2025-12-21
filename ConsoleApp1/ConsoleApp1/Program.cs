namespace ConsoleApp1
{     internal class Program
    {
        static void Main(string[] args)
        {
            // khai bao
            char a= 'G';
            int i = 89;
            short s = 56;
            long l = 4564;
            uint ui = 95;
            ushort us = 76;
            ulong ul = 3624573;
            double d = 8.358674532;
            float h = 3.7330645f;
            decimal dec=389.5m;
            // xuat du lieu
            Console.WriteLine("char: "+a);
            Console.WriteLine("integer: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + h);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("double: " + d);
            Console.WriteLine("Unsigned Integer: " + ui);
            Console.WriteLine("Unsigned short: " + us);
            Console.WriteLine("Unsigned long: " + ul);
            //con tro
            unsafe
            {
                int n = 10;
                int * p = &n;
                Console.WriteLine(n);
                Console.WriteLine((int)p);
            }
        }
    }
}