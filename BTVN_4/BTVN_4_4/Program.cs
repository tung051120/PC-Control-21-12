using System;
using System.Collections.Generic; 

class Program
{
    static void Main()
    {
      
        int n = int.Parse(Console.ReadLine());

        
        string[] inputArr = Console.ReadLine().Split(' ');

       
        int x = int.Parse(Console.ReadLine());

        
        List<int> ketQua = new List<int>();

        for (int i = 0; i < n; i++)
        {
            if (int.Parse(inputArr[i]) == x)
            {
                ketQua.Add(i); 
            }
        }

       
        if (ketQua.Count > 0)
        {
            
            Console.WriteLine(string.Join(" ", ketQua));
        }
        else
        {
            Console.WriteLine("Khong ton tai");
        }
    }
}