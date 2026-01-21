namespace BTVN_7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kiemtrakytu = Console.ReadLine();
            bool ketqua = kiemtrahople(kiemtrakytu);
            if (ketqua)
            {
                Console.WriteLine("chuoi hop le");
            }
            else
            {
                Console.WriteLine("chuoi khong hop le");
            }
        }
        static bool kiemtrahople(string input)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in input)
            {
                if (c == '(')
                {
                    stack.Push(c);

                }
                else if (c == ')')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }
            return stack.Count == 0;
        }
    }
}
