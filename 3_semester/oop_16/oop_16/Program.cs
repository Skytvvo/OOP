using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace oop_16
{

    
    class Program
    {
      

        static void Main(string[] args)
        {
            //1
            Stopwatch checker = Stopwatch.StartNew();
            Task<uint> resheto = Task.Factory.StartNew<uint>(() => {

                var numbers = new List<uint>();

                int n = 100000;

                for (var i = 2u; i < n; i++)
                {
                    numbers.Add(i);
                }
                for (var i = 0; i < numbers.Count; i++)
                {
                    for (var j = 2u; j < n; j++)
                    {
                        numbers.Remove(numbers[i] * j);
                    }
                }

                return (uint)numbers.Count;
            });
            Console.Write($"ID of task: {resheto.Id} ");
            if (resheto.IsCompleted)
                Console.WriteLine($"was completed, status: {resheto.Status}");
            else
                Console.WriteLine($"was interrupted, status: {resheto.Status}");

            checker.Stop();
            Console.WriteLine($"First task: {checker.Elapsed.TotalMilliseconds} ms");
            checker.Reset();

            //2
            CancellationTokenSource tokenSource =new CancellationTokenSource();
            checker.Start();
            Task<uint> reshetoTask2 = Task.Factory.StartNew<uint>(() => {
                var numbers = new List<uint>();
                int n = 100000;
                for (var i = 2u; i < n; i++)
                {
                    numbers.Add(i);
                }
                
                for (var i = 0; i < numbers.Count; i++)
                {
                    for (var j = 2u; j < n; j++)
                    {
                        numbers.Remove(numbers[i] * j);
                    }
                }

                return (uint)numbers.Count;
            }, tokenSource.Token);
            tokenSource.Cancel();

            Console.WriteLine($"ID of task: {reshetoTask2.Id} was canceled");
           
            

            checker.Stop();
            Console.WriteLine($"Second task: {checker.Elapsed.TotalMilliseconds} ms");

            //3
            Task<int> varX = Task.Factory.StartNew(() =>
            {
                return DateTime.Now.Second;
            });

            varX.Wait();

            Task<int> varY = Task.Factory.StartNew(() =>
            {
                return DateTime.Now.Millisecond;
            });

            varY.Wait();

            Task<int> varZ = Task.Factory.StartNew(() =>
            {
                return DateTime.Now.Month;
            });

            varZ.Wait();

            Task countFor = Task.Factory.StartNew(() =>
            {
                Console.WriteLine($"Result: {varZ.Result + varX.Result * varY.Result}");
            });

            //4

            countFor.ContinueWith((taskVAR) =>
            {
                Console.WriteLine("Continue with...");
            }).Wait();
            
             var  awaiterCountFor = countFor.GetAwaiter();
             awaiterCountFor.OnCompleted(() =>{
                awaiterCountFor.GetResult();
                Console.WriteLine("Awaiter...");
            });
            Thread.Sleep(100);

            //5
            var nums = new List<int>();
            int qua = 100000;

            for (var i = 0; i < qua; i++)
            {
                nums.Add(i);
            }
            Thread.Sleep(500);
            checker.Restart();
            Parallel.For(1, qua, Factorial);
            checker.Stop();
            Console.WriteLine($"For completed in {checker.Elapsed.TotalMilliseconds} ms");

            Console.WriteLine();
            checker.Restart();
            var forEachResult = Parallel.ForEach<int>(nums, Factorial);
            checker.Stop();
            Console.WriteLine($"ForEach completed in {checker.ElapsedMilliseconds} ms");

            checker.Restart();
            for (var i = 0; i <qua;i++)
            {
                Factorial(i);
            }
            checker.Stop();

            Console.WriteLine($"Standart for: {checker.ElapsedMilliseconds} ms");

            //6
            
            Parallel.Invoke(()=> {

                int result = 1;

                for (int i = 1; i <= qua; i++)
                {
                    result *= i;
                }
            });

            //7

            BlockingCollection<string> blockRoll = new BlockingCollection<string>();
            Task Seller = Task.Factory.StartNew(() =>
            {
                List<string> items = new List<string>() { "Axe", "Pickaxe", "Torch", "Torch", "Carrot", "Golden carrot" };
                Random ransd = new Random();
                int store = 0;
                for(int i = 0;items.Count!=0; i++)
                {
                    store = ransd.Next(0, items.Count - 1);
                    Console.WriteLine($"Item {items[store]} was delivered");
                    blockRoll.Add(items[store]);
                    items.RemoveAt(store);
                    Thread.Sleep(store);
                }
                blockRoll.CompleteAdding();
            });

            Task steve = Task.Factory.StartNew(() =>
            {
                string ff;
                while(!blockRoll.IsCompleted)
                {
                    if (blockRoll.TryTake(out ff))
                        Console.WriteLine($"Selled {ff}");
                    else
                        Console.WriteLine("Store empty");

                }
            });

            Seller.Wait();
            steve.Wait();

            //7
            asyncFactorial();

        }

        async static void asyncFactorial(int x = 100000)
        {
            Console.WriteLine();
            Console.WriteLine("Running async ...");
            await Task.Run(() => Factorial(x));
            Console.WriteLine("Ready!");
        }

        static void Factorial(int x = 100000)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
        }
    }
}
