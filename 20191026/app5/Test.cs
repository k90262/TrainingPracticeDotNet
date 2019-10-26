using System;
using System.Threading;
using System.Threading.Tasks;

class Test {
        public Task<int> Add(int a, int b) 
        {
            return Task<int>.Run(()=>{
                Thread.Sleep(5000);
                return a+b;
            });
        }

        public async void Go()
        {
            Console.WriteLine("Starting...");
            int ans = await Add(10, 20); // 呼叫方GO function也要有用async，這邊Add()才可用await去接非task的int
            Console.WriteLine($"answer={ans}");
        }

}