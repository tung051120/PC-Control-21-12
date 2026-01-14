using System.Runtime.Serialization.Formatters;

namespace BTVN_4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
            int[,] arr = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] rowInputs = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(rowInputs[j]);
                }

            }
            for (int i = 0; i < n; i++)
            {
                int tongtunghang = 0;   
                for (int j = 0; j < m; j++)
                {
                    tongtunghang += arr[i, j];
                }
                Console.WriteLine($"Tong hang {i}: {tongtunghang}");
            }
            for (int j = 0; j < m; j++)
            {
                int tongtungcot = 0;
                for (int i = 0; i < n; i++)
                {
                    tongtungcot += arr[i, j];
                }

                Console.WriteLine($"Tong cot {j}: {tongtungcot}");
            }
            int max = arr[0, 0];
            int min = arr[0, 0];
            int indexMaxRow = 0;
            int indexMaxCol = 0;
            int indexMinRow = 0;
            int indexMinCol = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        indexMaxRow = i;
                        indexMaxCol = j;
                    }
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        indexMinRow = i;
                        indexMinCol = j;
                    }
                }
            }

            Console.WriteLine("Phan tu lon nhat: " + max + " tai vi tri: (" + indexMaxRow + ", " + indexMaxCol + ")");
            Console.WriteLine("Phan tu nho nhat: " + min + " tai vi tri: (" + indexMinRow + ", " + indexMinCol + ")");
            if (n != m)
            {
                Console.WriteLine("Ma tran khong vuong, khong the doi xung.");
            }
            else
            {
                bool laDoiXung = true;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        
                        if (arr[i, j] != arr[j, i]) { laDoiXung = false; break; }
                    }
                    if (!laDoiXung) break;
                }
                Console.WriteLine(laDoiXung ? "Ma tran doi xung." : "Ma tran khong doi xung.");
            }
        
        }
    }
}
