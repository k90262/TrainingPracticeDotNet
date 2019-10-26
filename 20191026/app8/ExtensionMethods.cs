using System;
using System.Collections.Generic;

public static class ExtensionMethods 
{
    public static void Show(this IEnumerable<int> obj) 
    {
            foreach(int no in obj)
            {
                Console.Write($"{no}, ");
            }
            Console.WriteLine();
    }
}