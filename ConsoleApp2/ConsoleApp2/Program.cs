using System.IO;
    namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DirectoryInfo tm = new DirectoryInfo(@"D:\PC Control 2112\tung");
            tm.Create();
            Console.WriteLine(tm.FullName);
            DirectoryInfo tm1 = new DirectoryInfo(@"D:\PC Control 2112\hoicham");
            if(Directory.Exists(tm1.FullName))
            {
                Console.WriteLine("thu muc da ton tai");
            }
            else Console.WriteLine("thu muc chua ton tai");
            Directory.Delete(tm.FullName);
            string path = @"D:\PC Control 2112\module 1\BTVN_1\BTVN_1_1\obj";
            string [] file = Directory.GetFiles(path);
            foreach(string tep in file)
            {
                Console.WriteLine($"cac file trong danh sach la: {tep}");
            }
            string path1 = @"D:\";
            string[] dstm = Directory.GetDirectories(path1);
            foreach(string thumuc in dstm)
            {
                Console.WriteLine(thumuc);
            }
        }
    }
}
