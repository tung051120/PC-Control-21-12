namespace BTVN_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ket hop if else va array
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            int gioi=0;
            int kha=0;
            int trungbinh=0;
            int yeu=0;
            int n = int.Parse(Console.ReadLine());
            string Input = Console.ReadLine();
            string[] diem = Input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            n = diem.Length;
            double[] arr = new double[n];
            for(int i=0;i<diem.Length;i++)
            {
                arr[i] = double.Parse(diem[i]);
                if (arr[i]<5.0)
                {
                    yeu++;
                }
                else if (arr[i] >= 5.0 && arr[i]<=6.4)
                {
                    trungbinh++;
                }
                else if (arr[i] >= 6.5 && arr[i] <= 7.9)
                {
                    kha++;
                }
                else
                {
                    gioi++;
                }
            }
            Console.WriteLine("Gioi: "+gioi);
            Console.WriteLine("Kha: "+kha);
            Console.WriteLine("Trung binh: "+trungbinh);
            Console.WriteLine("Yeu: "+yeu);
        }
    }
}
