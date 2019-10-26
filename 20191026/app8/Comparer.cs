using System.Collections;

class Comparer : IComparer
{
    public int Compare(object x, object y)
    {
        int a = (int)x;
        int b = (int)y;
        //return a-b; // asc
        //return b-a; // desc

        if (a % 2 == 1 && b % 2 == 0)
            return -1; // 奇數在前，偶數在後
        else if (a % 2 == 1 && b % 2 == 1)
            return a-b;
        else if (a % 2 == 0 && b % 2 ==0)
            return b-a;
        else 
            return 0;
    }
}