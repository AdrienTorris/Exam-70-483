namespace Exam70483CodeSamples.Threading._07
{
    using System;
    using System.Threading;

    /// <summary>
    /// Using the ThreadPool
    /// </summary>
    /// <see cref="https://msdn.microsoft.com/en-us/library/system.threading.threadpool(v=vs.110).aspx"/>
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool");
            });

            Console.ReadLine();
        }
    }
}