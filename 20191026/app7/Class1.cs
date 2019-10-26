using System;

public static class Class1 // 不一定要寫在同一個class內，只要是靜態類別即可
{
    public static void Show(this int no)
    {
       Console.WriteLine(no);
    }

    public static int Double(this int no)
    {
        return no * 2;
    }

    public static int Mul(this int no, int refactor) // 帶參數
    {
        return no * refactor;
    }
}