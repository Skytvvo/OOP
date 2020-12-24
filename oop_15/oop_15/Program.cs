using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace oop_15
{
    class Program
    {
        static string path;
        static int n = 20;
        static int g = 1;
        static void Main(string[] args)
        {
            path = @".\Lab.log";
            using (StreamWriter clearFile = new StreamWriter(path, false))
            {
                clearFile.WriteLine("");
            }

            Process[] currentProcesses = Process.GetProcesses();
            foreach(var item in currentProcesses)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(path, true))
                    {
                       
                            sw.WriteLine("=======================================");
                        sw.WriteLine($"ID:{item.Id}");
                        sw.WriteLine($"Name:{item.ProcessName}");
                        sw.WriteLine($"Priority:{item.BasePriority}");
                        sw.WriteLine($"Time-start:{item.StartTime.ToString()}");
                        sw.WriteLine($"State:{item.Responding.ToString()}");
                        sw.WriteLine($"Runt-itme:{item.GetLifetimeService()}");
                        sw.WriteLine("=======================================");
                    }
                }
                catch
                {
                    continue;
                }
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine($"Domain name:{Thread.GetDomain().FriendlyName}");
                sw.WriteLine($"Configuration details: {Thread.GetDomain().SetupInformation}");
                sw.WriteLine($"Assemlies: \n");
                foreach(var item in Thread.GetDomain().GetAssemblies())
                {
                    sw.WriteLine($"Name: {item.GetName()}");
                }
            }
            AppDomain newDomain = AppDomain.CreateDomain("NewDomain");
            
            newDomain.Load(Assembly.GetExecutingAssembly().GetName());
            AppDomain.Unload(newDomain);
            int userInput = Convert.ToInt32(Console.ReadLine());
            Oper param = new Oper(userInput, path);
            Thread newThread = new Thread(new ThreadStart(param.countO));
            newThread.Name = "My thread";

            newThread.Start();
            newThread.Join();

            Thread evenTh = new Thread(new ThreadStart( evenum));
            Thread oddTh = new Thread(new ThreadStart(oddnum));

            evenTh.Start();
            oddTh.Start();
            
            evenTh.Priority = ThreadPriority.Highest;
            oddTh.Priority = ThreadPriority.Lowest;



            evenTh.Join();
            
            oddTh.Join();
           
            TimerCallback tiktak = new TimerCallback(clockTIK);
            Timer tm = new Timer(tiktak, 60, 0, 1000);
            Console.ReadLine();
        }

        static public void evenum()
        {
            for(int i = 0; i < n; i++)
            {
                if(i %2==0)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(260);
                }
            }
        }

        static public void oddnum()
        {
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(460);
                }
            }
        }

        static public void clockTIK(object par)
        {
            if (g % 2 == 0)
                Console.WriteLine($"Tak - {g}");
            else
                Console.WriteLine($"Tik - {g}");
            g++;
        }

    }
    public class Oper
    {
        int x;
        Thread savedThread = Thread.CurrentThread;
        string path;
        public void countO()
        {
            using (StreamWriter sw = new StreamWriter(this.path, true))
            {
                try
                {
                    for (int i = 1; i < x; i++)
                    {
                        
                        Console.WriteLine($"Thread status: {Thread.CurrentThread.ThreadState}");
                        sw.WriteLine($"Thread status: {Thread.CurrentThread.ThreadState}");

                        Console.WriteLine($"Thread name: {Thread.CurrentThread.Name}");
                        sw.WriteLine($"Thread name: {Thread.CurrentThread.Name}");

                        Console.WriteLine($"Thread priority: {Thread.CurrentThread.Priority}");
                        sw.WriteLine($"Thread priority: {Thread.CurrentThread.Priority}");

                        Console.WriteLine($"Thread id: {Thread.CurrentThread.GetHashCode()}");
                        sw.WriteLine($"Thread id: {Thread.CurrentThread.GetHashCode()}");
                        Thread.Sleep(500);
                        
                    }
                }
                catch(Exception e)
                {
               
                    Console.WriteLine(e.Message);
                    return;
                }
            }

        }

        public Oper(int x, string path)
        {
            this.x = x;
            this.path = path;
        }

    }
    
}
