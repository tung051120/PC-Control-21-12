namespace BTVN_7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> quanlynhiemvu = new Queue<string>();
            Console.WriteLine("nhap cac nhiem vu can xu ly(nhan 1 de hoan thanh): ");
            while (true)
            {
                string sanxuatnhiemvu = Console.ReadLine();
                if (sanxuatnhiemvu == "1")
                    break;
                quanlynhiemvu.Enqueue(sanxuatnhiemvu);
            }
            while (quanlynhiemvu.Count > 0)
            {
                string tieuthunhiemvu;
                tieuthunhiemvu = quanlynhiemvu.Dequeue();
                Console.WriteLine($"dang xu ly nhiem vu {tieuthunhiemvu}");
                System.Threading.Thread.Sleep(1500);
            }
        }
    }
}
