namespace BTVN_7_1
{
    internal class Program
    {
        static Stack<string> undostack = new Stack<string>();
        static Stack<string> redostack = new Stack<string>();
        static void nhaplenhmoi()
        {
            Console.WriteLine("nhap lenh moi: ");
            string command = Console.ReadLine();
            if (!string.IsNullOrEmpty(command))
            {
                undostack.Push(command);
                redostack.Clear();
            }
        }
        static void undo()
        {
            if (undostack.Count > 0)
            {
                string command = undostack.Pop();
                redostack.Push(command);
                Console.WriteLine($" da hoan tac lenh {command}");
            }
            else
            {
                Console.WriteLine("khong co lenh de hoan tac");
            }

        }
        static void redo()
        {
            if (redostack.Count > 0)
            {
                string command = redostack.Pop();
                undostack.Push(command);
                Console.WriteLine($" da lam lai lenh {command}");
            }
            else
            {
                Console.WriteLine("khong co lenh de lam lai");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. nhap lenh moi");
                Console.WriteLine("2. thuc hien undo");
                Console.WriteLine("3. thuc hien redo");
                string tuychon = Console.ReadLine();
                switch (tuychon)
                {
                    case "1":
                        nhaplenhmoi();
                        break;
                    case "2":
                        undo();
                        break;
                    case "3":
                        redo();
                        break;

                }

            }

        }
    }
}
