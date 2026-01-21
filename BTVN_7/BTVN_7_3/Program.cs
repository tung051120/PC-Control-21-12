namespace BTVN_7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> daychuyen = new Queue<string>();
            Console.WriteLine("nhap ten san pham can gia cong, nhap 'hoan thanh' de bat dau xu ly cac san pham");
            while (true)
            {

                string input = Console.ReadLine();
                if (input == "hoan thanh")
                    break;
                daychuyen.Enqueue(input);
            }
            while (daychuyen.Count > 0)
            {
                string sanpham = daychuyen.Dequeue();
                Console.WriteLine($"dang xu ly san pham {sanpham}");
                System.Threading.Thread.Sleep(1500);
            }
        }
    }
}
