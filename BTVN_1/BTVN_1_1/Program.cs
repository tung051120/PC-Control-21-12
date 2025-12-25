namespace BTVN_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // viet chuong trinh khai bao va in ra tat ca cac kieu du lieu co ban
            Console.WriteLine("---viet chuong trinh khai bao va in ra tat ca cac kieu du lieu co ban---");
            int a = -200511;
            long b = -32047230583;
            short c = -607;
            byte d = 200;
            double e = 235.3242345;
            float f = 511.667f;
            decimal g = 14135412351.312423523m;
            char h = 'T';
            string i = "Hello everyone!";
            bool j = false;
            uint k = 2005;
            ushort l = 6689;
            ulong m = 320423432;
            sbyte n = -99;
            object o = b;
            //de co the thuc hien phep toan thi can phai unboxing de lay gia tri ben trong object ra
            long ketqua=(long)o + 1000098997;
            Console.WriteLine("int a = " + a);
            Console.WriteLine("long b = " + b);
            Console.WriteLine("short c = " + c);
            Console.WriteLine("byte d = " + d);
            Console.WriteLine("double e = " + e);
            Console.WriteLine("float f = " + f);
            Console.WriteLine("decimal g = " + g);
            Console.WriteLine("char h = " + h);
            Console.WriteLine("string i = " + i);
            Console.WriteLine("bool j = " + j);
            Console.WriteLine("uint k = " + k);
            Console.WriteLine("ushort l = " + l);
            Console.WriteLine("ulong m = " + m);
            Console.WriteLine("sbyte n = " + n);
            Console.WriteLine("gia tri ben trong object la: "+o);
            Console.WriteLine("ket qua phep toan giua object va 1000098997 la: " + ketqua);
            unsafe
            {
                int* ptr = &a;
                *ptr = 60000;
                Console.WriteLine("dia chi con tro chi vao la: " + (int)ptr);
                Console.WriteLine("gia tri cua a sau khi duoc con tro thay doi gia tri la:" + *ptr);
            }
        }
    }
}
