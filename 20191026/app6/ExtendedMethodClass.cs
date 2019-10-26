using System;
using System.Collections;
using System.Collections.Generic;

public static class ExtendedMethodClass 
{
    public static void Show(this IEnumerable obj) 
    {
            foreach(int no in obj)
            {
                Console.Write($"{no}, ");
            }
            Console.WriteLine();
    }
}