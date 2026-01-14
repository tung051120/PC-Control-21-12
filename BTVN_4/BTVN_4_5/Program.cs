namespace BTVN_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // xu ly chuoi va mang 
            string cau = Console.ReadLine();
            int sokytu = cau.Length;
            int sokhoangtrang = 0;
            foreach (char c in cau)
            {
                if (c == ' ')
                {
                    sokhoangtrang++;
                }
            }
            string[] tachtu = cau.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int sotu = tachtu.Length;
            string maxlength = "";
            string minlength ="";
            if(sotu>0)
            {
                maxlength = tachtu[0];
                minlength = tachtu[0];
                foreach(string  tu in tachtu)
                {
                    if (tu.Length>maxlength.Length) maxlength = tu;
                    if (tu.Length < minlength.Length) minlength = tu;
                }
            }
            Console.WriteLine("so ky tu: "+sokytu);
            Console.WriteLine("so tu: "+sotu);
            Console.WriteLine("so khoang trang: "+sokhoangtrang);
            Console.WriteLine("tu dai nhat: "+maxlength);
            Console.WriteLine("tu ngan nhat: "+minlength);

        }
    }
}
