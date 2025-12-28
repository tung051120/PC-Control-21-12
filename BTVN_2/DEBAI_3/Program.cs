namespace DEBAI_3
{
    internal class Program
    {
        static double quydoi(ref double sogio) //3. viet ham
        {
            const int MIN_PER_HOUR = 60; // 1. khai bao hang so
            const int SALARY_PER_HOUR = 45000;
            sogio = sogio/MIN_PER_HOUR; // quy doi tu phut sang gio
            sogio = Math.Round(sogio, 0); // lam tron
            double tienluong = sogio * SALARY_PER_HOUR; // tinh tien luong
            return tienluong; // tra ve ket qua la tien luong
        }
        static void Main(string[] args)
        {
            Console.WriteLine("moi nhap vao tong so phut lam viec: ");
            int soPhut = int.Parse(Console.ReadLine()); // 2. khai bao tong so phut lam viec int nhpa tu ban phim
            Console.WriteLine($"tong so phut lam viec la: {soPhut} phut");
            double soPhutdouble = (double)soPhut;
            double tienluong=quydoi(ref soPhutdouble);
            Console.WriteLine($"so gio lam viec la: {soPhutdouble}");
            Console.WriteLine("tong tien luong phai tra la: " + tienluong);       //in ra tong tien luong phai tra                                    
            Console.WriteLine();
        }
    }
}
