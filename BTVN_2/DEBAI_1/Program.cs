namespace DEBAI_1
{
    internal class Program
    {
        static void ThongTInSSanPham (double dongia,int soluong) //2. ham nhap don gia va so luong
        {
            Console.WriteLine($"don gia: {dongia}");
            Console.WriteLine($"so luong: {soluong}");
        }
        static void tinhtien (double dongia, int soluong, decimal VAT, out decimal tongtien, out decimal thueVAT) //3. ham tinh tien
        {
            double thanhtien = dongia * soluong;
             thueVAT = (decimal)thanhtien * VAT;
             tongtien = (decimal)thanhtien + thueVAT;
          
        }
        static void tangsoluong(ref int soluong) //4. ham tang so luong
        {
            soluong++;
        }
        static void Main(string[] args)
        {
            const decimal VAT = 0.1m;//1. khai bao hang so VAT la 10%      
            Console.WriteLine("don gia san pham la: ");
            double dongia = double.Parse(Console.ReadLine());
            Console.WriteLine("so luong san pham la: ");    
            int soluong = int.Parse(Console.ReadLine());
            tangsoluong(ref soluong);
            ThongTInSSanPham(dongia, soluong);           
            decimal tongtien, thueVAT;
            tinhtien(dongia, soluong, VAT, out tongtien, out thueVAT);//5. ham tra ve tong tien va thue VAT            
            int tongtienint = (int)tongtien; //6. ep kieu tong tien ve int
            Console.WriteLine($"tong tien can phai tra la: {tongtienint}"); //7. in ket qua ra man hinh 
        }
    }
}
