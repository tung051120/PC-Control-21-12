using System.Reflection.Metadata.Ecma335;

namespace BTVN_5_1
{
    internal class Program
    {
        static List<string> danhsachthietbi = new List<string>();
        static void Main(string[] args)
        {
            

            
            while (true)
            {

                Console.WriteLine("---MENU---");
                Console.WriteLine("1. Them thiet bi");
                Console.WriteLine("2. xu ly thiet bi");
                Console.WriteLine("3. hien thi thiet bi");
                Console.WriteLine("4. xoa thiet bi");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        themthietbi(choose);
                        break;
                    case "2":
                        xulythietbi();
                        break;
                    case "3":
                        hienthithietbi();
                        break;
                    case "4":
                        xoathietbi();
                        break;
                    case "0":
                        return;
                    default:
                        continue;

                }
            }


        }
       // 2.1 them thiet bi
        static void themthietbi(string themthietbi)
        {
            themthietbi = Console.ReadLine();
            if (string.IsNullOrEmpty(themthietbi)) return;
            if (!themthietbi.StartsWith("PLC") && !themthietbi.StartsWith("CAM") && !themthietbi.StartsWith("SENSORS")) return;
            if(danhsachthietbi.Contains(themthietbi)) return;
            danhsachthietbi.Add(themthietbi);
        }
        // 2.2 xu ly thiet bi
        static void xulythietbi()
        {
            foreach(string tb in danhsachthietbi)
            {
                if (tb.Contains("ERROR")) continue;
                if (tb.Contains("STOP")) break;
                Console.WriteLine($"dang xu ly thiet bi {tb}");
            }
            
        }
        // 2.3 xoa thiet bi
        static void xoathietbi()
            {
            if (danhsachthietbi.Count == 0)
            { Console.WriteLine("chua co thiet bi de xoa"); return; }
            string xoathietbi = Console.ReadLine();
            
            if (!danhsachthietbi.Contains(xoathietbi)) return;
            if (xoathietbi.Contains("PLC")) return;
            danhsachthietbi.Remove(xoathietbi);
        }
        // hien thi thiet bi
         static void hienthithietbi()
        {
            Console.WriteLine("danh sach thiet bi:");
            if (danhsachthietbi.Count == 0)
            { Console.WriteLine("trong"); return; }
            foreach (string tb in danhsachthietbi)
            {
                
                Console.WriteLine(tb);
            }
        }
    }
}
