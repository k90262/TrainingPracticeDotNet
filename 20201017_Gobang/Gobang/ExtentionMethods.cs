using System;
using System.Collections.Generic;

namespace Hello
{
    static class ExtensionMethods
    {

        public static List<int> Filter(this int[] data, Func<int, bool> f)
        {
            List<int> result = new List<int>();
            foreach (int no in data)
            {
                if (f.Invoke(no))
                {
                    result.Add(no);
                }
            }

            return result;
        }

    }
}