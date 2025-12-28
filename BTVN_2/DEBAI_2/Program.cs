namespace DEBAI_2
{
    internal class Program
    {
        static double chuyendoi(ref double chisotieuthu) //3. ham tinh tien dien
        {
            const int WH_TO_KWH = 1000; //1. khai bao hang so 
            const int PRICE_PER_KWH = 2500;
            chisotieuthu = chisotieuthu / WH_TO_KWH; // tinh so dien tieu thu kwh
            chisotieuthu = Math.Round(chisotieuthu, 0); // lam tron so dien tieu thu
            double tiendien =chisotieuthu * PRICE_PER_KWH; // tinh tien dien            
            return tiendien; // tra ve ket qua la tien dien
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("nhap so dien tieu thu trong thang: ");
            double soDienTieuThu = int.Parse(Console.ReadLine());// 2. du lieu dau vao
            Console.WriteLine($"so dien tieu thu trong thang la: {soDienTieuThu} WH"); 
            double sotien = chuyendoi(ref soDienTieuThu); // goi ham tinh tien dien

            Console.WriteLine($"so dien tieu thu sau khi quy doi: {soDienTieuThu}"); // in ra so dien tieu thu sau khi quy doi
            Console.WriteLine("tong tien dien phai tra la:"+sotien); // in ra tong tien dien phai tra

        }
    }
}
