namespace BTVN_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tao chuong trinh tinh toan tai chinh su dung decimal
            Console.WriteLine("---tao chuong trinh tinh toan tai chinh su dung decimal---");
            Console.WriteLine("moi nhap vao san pham: ");
            string product = Console.ReadLine(); // nhap ten san pham
            Console.WriteLine("moi nhap vao gia tien (USD): ");
            decimal price = Convert.ToDecimal(Console.ReadLine()); // nhap gia moi san pham
            Console.WriteLine("moi nhap vao so luong: ");
            uint quantity = Convert.ToUInt32(Console.ReadLine()); // nhap so luong san pham
            Console.WriteLine("moi nhap vao thue suat (%): ");
            decimal inputTax = Convert.ToDecimal(Console.ReadLine()); // thue suat nhap vao dang phan tram
            decimal actualTax = inputTax / 100; // chuyen thue suat ve dang thap phan
            decimal total = price * quantity; // tinh tong tien truoc thue
            decimal totalAfterTax = total + (total * actualTax); // tinh tong tien sau thue
            Console.WriteLine("---HOA DON CHI TIET---");
            // PHAN NAY EM DUNG NOI SUY CHUOI CHO DEP MAT HON 
            Console.WriteLine($"San pham: {product}");
            Console.WriteLine($"Gia tien: {price}");
            Console.WriteLine($"So luong: {quantity} ");
            Console.WriteLine($"VAT: {inputTax}%");
            Console.WriteLine($"Tong tien truoc thue: {total} ");
            Console.WriteLine($"Tong tien sau thue: {totalAfterTax}");

        }
    }
}
