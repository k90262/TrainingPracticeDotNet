using System;

namespace app7
{
    class Program
    {
        static void Main(string[] args)
        {
            int no1 = 10;
            no1.Show();

            int no2 = no1.Double();
            no2.Show();

            int no3 = no2.Mul(10); // 步驟: 1. 於一個類別內定義Mul(), 2. 將Mul改成靜態(不用new即可被呼叫)), 3. 將Mul的第一個參數使用"this int xxx"，擴充int；並加入參數, 4. 將該類別設定成靜態類別. Done
            no3.Show();
        }
    }
}
