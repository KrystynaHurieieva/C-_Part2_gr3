using System.Diagnostics;
using System.Threading;

namespace Lecture2
{//TPL PLINQ
    internal class Program
    {
        delegate void Message();
        static async Task Main(string[] args)
        {
            { // Console.WriteLine("Hello, World!"); // async/await 
              // /*
              //  * THREAD
              //  * - async 
              //  * - await 
              //  * void 
              //  * Task <int>
              //  * async Task<int> Sum(int a, int b) -- ref out 
              //  * {
              //  * }
              //  */
              // var stopwatch = new Stopwatch();
              // stopwatch.Start();
              // var test = new Test();
              // test.PrintName("Tom");
              // test.PrintName("Bob");
              // test.PrintName("Rob");
              // stopwatch.Stop();
              // Console.WriteLine($"{stopwatch.ElapsedMilliseconds}");
              // stopwatch.Reset();

                // stopwatch.Start();
                // var test1 = new Test();
                // var tom = test1.PrintNameAsync("Tom");
                // var bob = test1.PrintNameAsync("Bob");
                // var rob = test1.PrintNameAsync("Rob");

                // //var restom = await tom;
                // //var resbob = await bob;
                // //var resrob = await rob;
                //var res = await Task.WhenAll(tom, bob, rob);
                // foreach (var item in res)
                // {
                //     Console.WriteLine(item);
                // }
                // //Console.WriteLine(restom);
                // //Console.WriteLine(resbob);
                // //Console.WriteLine(resrob);
                // stopwatch.Stop();
                // Console.WriteLine($"{stopwatch.ElapsedMilliseconds}");
                // //await test.PrintAsync();
                // Console.WriteLine("Some actions");
            }

            {     //for(var i = 0; i< 10; i++)
                  //{
                  //    Thread.Sleep(1000);
                  //    Console.WriteLine(i);
                  //}
                  //   var test = new Test();
                  //   var thread1 = new Thread(test.Print);
                  //// var thread2 = new Thread(() => Console.WriteLine("Hello, World!!!!!!"));

                //   thread1.Start();
                //   //thread2.Start();


                //   for (var i = 0; i < 10; i++)
                //   {
                //       Thread.Sleep(900);
                //       Console.WriteLine($" Main thread {i}");
                //   }
            }

            {  //var test = new Test();
               //for (int i = 1; i < 5; i++)
               //{
               //    var thread = new Thread(test.Print);
               //    thread.Name = $"Thread {i}";
               //    thread.Start();
               //}
            }
            var test = new Test();

            Message message;
            message = test.Hello;
            message();

            message += test.HelloMyName;
            message();

        }
    }

    public class Test
    {
        public void Hello() => Console.WriteLine("Hello");
        public void HelloMyName() => Console.WriteLine("I'm Kris");
        object locker = new();
        public int x { get; set; }
        public void Print()
        {

            //lock (locker)
            {
                for (var i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                    x++;

                    Thread.Sleep(1000);
                }
            }

            //Thread.Sleep(3000);
            //Console.WriteLine("Hello, World!");
        }

        public async Task PrintAsync()
        {
            Console.WriteLine($"PrintAsync start");
            await Task.Run(() => Print());
            Console.WriteLine($"PrintAsync end");

            Thread.Sleep(4000);
        }

        public void PrintName(string name)
        {
            Thread.Sleep(3000);
            Console.WriteLine($"Hello, {name}");
        }
        public async Task<string> PrintNameAsync(string name)
        {
            await Task.Delay(3000);
            Console.WriteLine($"Hello, {name}");
            return $"My name is {name}";
        }


    }
}