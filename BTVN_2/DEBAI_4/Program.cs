namespace DEBAI_4
{
    internal class Program
    {
        static double tinhthue (ref double giagoc) //3. ham tinh gia sau thue
        {
            const double VAT = 0.1; //1. khai bao hang so
            double thue = giagoc * VAT; // tinh tien thue
            double giasauthue = giagoc + thue; // tinh gia sau thue
            giagoc = (int)Math.Round(giasauthue, 0); // lam tron gia sau thue va ghi de vao gia goc
            return giasauthue; // tra ve ket qua la gia sau thue chua lam tron

        }
        static void Main(string[] args)
        {
            Console.WriteLine("gia goc cua san pham la: ");
            double giagoc = double.Parse(Console.ReadLine());//2. du lieu dau vao
            Console.WriteLine($"gia goc cua san pham truoc thue la: {giagoc}");
            double giasauthue = tinhthue (ref giagoc); // goi ham tinh gia sau thue
            Console.WriteLine($"gia san pham sau thue la: {giasauthue}"); // in ra gia san pham sau thue chua lam tron
            Console.WriteLine("gia sau thue sau khi lam tronla: "+giagoc); // in ra gia san pham sau thue da lam tron
        }
    }
}
